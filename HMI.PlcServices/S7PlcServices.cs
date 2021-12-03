using Sharp7;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace HMI.PlcServices
{
    public class S7PlcServices
    {
        private readonly S7Client _client;
        private readonly System.Timers.Timer _timer;
        private DateTime _lastScantime;

        private volatile object _locker = new object();

        public S7PlcServices()
        {
            _client = new S7Client();
            _timer = new System.Timers.Timer();
            _timer.Interval = 100;
            _timer.Elapsed += OnTimerElapsed;
        }

       
        public ConnectionStates ConnectionState { get; private set; }
        public bool R111 { get; private set; }
        public bool R112 { get; private set; }
        public bool R113 { get; private set; }
        public bool R114 { get; private set; }
        public bool R115 { get; private set; }
        public bool R116 { get; private set; }
        public bool R117 { get; private set; }
        public bool R118 { get; private set; }
        public bool R119 { get; private set; }
        public bool R1110 { get; private set; }
        public bool R1111 { get; private set; }
        public bool R1112 { get; private set; }
        public bool R1113 { get; private set; }
        public bool R1114 { get; private set; }
        public bool R1115{ get; private set; }
        public bool R1116{ get; private set; }
        public bool R1117{ get; private set; }
        public bool R1118{ get; private set; }

        public bool R121{ get; private set; }
        public bool R122{ get; private set; }
        public bool R123 { get; private set; }
        public bool R124 { get; private set; }
        public bool R125 { get; private set; }
        public bool R126 { get; private set; }
        public bool R127 { get; private set; }
        public bool R128 { get; private set; }
        public bool R129 { get; private set; }
        public bool R1210 { get; private set; }
        public bool R1211 { get; private set; }
        public bool R1212 { get; private set; }
        public bool R1213 { get; private set; }
        public bool R1214 { get; private set; }
        public bool R1215 { get; private set; }
        public bool R1216{ get; private set; }
        public bool R1217 { get; private set; }
        public bool R1218 { get; private set; }

        public bool R131 { get; private set; }
        public bool R132 { get; private set; }
        public bool R133 { get; private set; }
        public bool R134 { get; private set; }
        public bool R135 { get; private set; }
        public bool R136 { get; private set; }
        public bool R137 { get; private set; }
        public bool R138 { get; private set; }
        public bool R139 { get; private set; }
        public bool R1310 { get; private set; }
        public bool R1311 { get; private set; }
        public bool R1312 { get; private set; }
        public bool R1313 { get; private set; }
        public bool R1314 { get; private set; }
        public bool R1315 { get; private set; }
        public bool R1316 { get; private set; }
        public bool R1317 { get; private set; }
        public bool R1318 { get; private set; }

        public bool R141 { get; private set; }
        public bool R142 { get; private set; }
        public bool R143 { get; private set; }
        public bool R144 { get; private set; }
        public bool R145 { get; private set; }
        public bool R146 { get; private set; }
        public bool R147 { get; private set; }
        public bool R148 { get; private set; }
        public bool R149 { get; private set; }
        public bool R1410 { get; private set; }
        public bool R1411 { get; private set; }
        public bool R1412 { get; private set; }
        public bool R1413 { get; private set; }
        public bool R1414 { get; private set; }
        public bool R1415 { get; private set; }
        public bool R1416 { get; private set; }
        public bool R1417 { get; private set; }
        public bool R1418 { get; private set; }

        public bool R151 { get; private set; }
        public bool R152 { get; private set; }
        public bool R153 { get; private set; }
        public bool R154 { get; private set; }
        public bool R155 { get; private set; }
        public bool R156 { get; private set; }
        public bool R157 { get; private set; }
        public bool R158 { get; private set; }
        public bool R159 { get; private set; }
        public bool R1510 { get; private set; }
        public bool R1511 { get; private set; }
        public bool R1512 { get; private set; }
        public bool R1513 { get; private set; }
        public bool R1514 { get; private set; }
        public bool R1515 { get; private set; }
        public bool R1516 { get; private set; }
        public bool R1517 { get; private set; }
        public bool R1518 { get; private set; }
        public TimeSpan ScanTime { get; private set; }
        public event EventHandler ValuesRefreshed;

       
        
        //CONNECT TO PLC
        public void Connect (string ipAddress, int rack, int slot)
        {
            try
            {
                ConnectionState = ConnectionStates.Connecting;
                int result = _client.ConnectTo(ipAddress, rack, slot);
                if (result == 0)
                {
                    ConnectionState = ConnectionStates.Online;
                    _timer.Start();
                }
                else
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\t Connection error: " + _client.ErrorText(result));
                    ConnectionState = ConnectionStates.Offline;
                }
                OnValuesRefreshed();
            }
            catch
            {
                ConnectionState = ConnectionStates.Offline;
                OnValuesRefreshed();
                throw;
            }
        }

        // DISCONNECT
        public void Disconnect()
        {
            if (_client.Connected)
            {
                _timer.Stop();
                _client.Disconnect();
                ConnectionState = ConnectionStates.Offline;
                OnValuesRefreshed();
            }
        }


    

        // CLICK BUTTON
        public async Task WriteButton(string address)
        {
            await Task.Run(() =>
            {
                int writeResult = WriteBit(address, true);
                if (writeResult != 1)
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\t Write error: " + _client.ErrorText(writeResult));
                }
                Thread.Sleep(30);
                writeResult = WriteBit(address, false);
                if (writeResult != 1)
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\t Write error: " + _client.ErrorText(writeResult));
                }
            });
        }
        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                _timer.Stop();
                ScanTime = DateTime.Now - _lastScantime;
                RefreshValues();
                OnValuesRefreshed();
            }
            finally
            {
                _timer.Start();
            }
            _lastScantime = DateTime.Now;
        }

        private void RefreshValues()
        {
            lock (_locker)
            {
               
                // CLICK MULTI VAR (NHIEU BIEN)
                var s7MultiVar = new S7MultiVar(_client);
                byte[] buffer0 = new byte[50];
                s7MultiVar.Add(S7Consts.S7AreaDB, S7Consts.S7WLByte, 5, 0, 12, ref buffer0);
                // Trong s7MultiVar: thông số 5: là nằm ở khối DB5, 0 là bắt đầu, 12: số lượng (cứ tăng dần cho đến khi thỏa mãn yêu cầu)
                int result0 = s7MultiVar.Read();
                if (result0 ==0)
                {
                    R111 = S7.GetBitAt(buffer0, 0, 2);
                    R112 = S7.GetBitAt(buffer0, 0, 3);
                    R113 = S7.GetBitAt(buffer0, 0, 4);
                    R114 = S7.GetBitAt(buffer0, 0, 5);
                    R115 = S7.GetBitAt(buffer0, 0, 6);
                    R116 = S7.GetBitAt(buffer0, 0, 7);
                    R117 = S7.GetBitAt(buffer0, 1, 0);
                    R118 = S7.GetBitAt(buffer0, 1, 1);
                    R119 = S7.GetBitAt(buffer0, 1, 2);
                    R1110 = S7.GetBitAt(buffer0, 1, 3);
                    R1111 = S7.GetBitAt(buffer0, 1, 4);
                    R1112 = S7.GetBitAt(buffer0, 1, 5);
                    R1113 = S7.GetBitAt(buffer0, 1, 6);
                    R1114 = S7.GetBitAt(buffer0, 1, 7);
                    R1115 = S7.GetBitAt(buffer0, 2, 0);
                    R1116 = S7.GetBitAt(buffer0, 2, 1);
                    R1117 = S7.GetBitAt(buffer0, 2, 2);
                    R1118 = S7.GetBitAt(buffer0, 2, 3);

                    R121 = S7.GetBitAt(buffer0, 2, 4);
                    R122 = S7.GetBitAt(buffer0, 2, 5);
                    R123 = S7.GetBitAt(buffer0, 2, 6);
                    R124 = S7.GetBitAt(buffer0, 2, 7);
                    R125 = S7.GetBitAt(buffer0, 3, 0);
                    R126 = S7.GetBitAt(buffer0, 3, 1);
                    R127 = S7.GetBitAt(buffer0, 3, 2);
                    R128 = S7.GetBitAt(buffer0, 3, 3);
                    R129 = S7.GetBitAt(buffer0, 3, 4);
                    R1210 = S7.GetBitAt(buffer0, 3, 5);
                    R1211 = S7.GetBitAt(buffer0, 3, 6);
                    R1212 = S7.GetBitAt(buffer0, 3, 7);
                    R1213 = S7.GetBitAt(buffer0, 4, 0);
                    R1214 = S7.GetBitAt(buffer0, 4, 1);
                    R1215 = S7.GetBitAt(buffer0, 4, 2);
                    R1216 = S7.GetBitAt(buffer0, 4, 3);
                    R1217 = S7.GetBitAt(buffer0, 4, 4);
                    R1218 = S7.GetBitAt(buffer0, 4, 5);

                    R131 = S7.GetBitAt(buffer0, 4, 6);
                    R132 = S7.GetBitAt(buffer0, 4, 7);
                    R133 = S7.GetBitAt(buffer0, 5, 0);
                    R134 = S7.GetBitAt(buffer0, 5, 1);
                    R135 = S7.GetBitAt(buffer0, 5, 2);
                    R136 = S7.GetBitAt(buffer0, 5, 3);
                    R137 = S7.GetBitAt(buffer0, 5, 4);
                    R138 = S7.GetBitAt(buffer0, 5, 5);
                    R139 = S7.GetBitAt(buffer0, 5, 6);
                    R1310 = S7.GetBitAt(buffer0, 5, 7);
                    R1311 = S7.GetBitAt(buffer0, 6, 0);
                    R1312 = S7.GetBitAt(buffer0, 6, 1);
                    R1313 = S7.GetBitAt(buffer0, 6, 2);
                    R1314 = S7.GetBitAt(buffer0, 6, 3);
                    R1315 = S7.GetBitAt(buffer0, 6, 4);
                    R1316 = S7.GetBitAt(buffer0, 6, 5);
                    R1317 = S7.GetBitAt(buffer0, 6, 6);
                    R1318 = S7.GetBitAt(buffer0, 6, 7);

                    R141 = S7.GetBitAt(buffer0, 7, 0);
                    R142 = S7.GetBitAt(buffer0, 7, 1);
                    R143 = S7.GetBitAt(buffer0, 7, 2);
                    R144 = S7.GetBitAt(buffer0, 7, 3);
                    R145 = S7.GetBitAt(buffer0, 7, 4);
                    R146 = S7.GetBitAt(buffer0, 7, 5);
                    R147 = S7.GetBitAt(buffer0, 7, 6);
                    R148 = S7.GetBitAt(buffer0, 7, 7);
                    R149 = S7.GetBitAt(buffer0, 8, 0);
                    R1410 = S7.GetBitAt(buffer0, 8, 1);
                    R1411 = S7.GetBitAt(buffer0, 8, 2);
                    R1412 = S7.GetBitAt(buffer0, 8, 3);
                    R1413 = S7.GetBitAt(buffer0, 8, 4);
                    R1414 = S7.GetBitAt(buffer0, 8, 5);
                    R1415 = S7.GetBitAt(buffer0, 8, 6);
                    R1416 = S7.GetBitAt(buffer0, 8, 7);
                    R1417 = S7.GetBitAt(buffer0, 9, 0);
                    R1418 = S7.GetBitAt(buffer0, 9, 1);

                    R151 = S7.GetBitAt(buffer0, 9, 2);
                    R152 = S7.GetBitAt(buffer0, 9, 3);
                    R153 = S7.GetBitAt(buffer0, 9, 4);
                    R154 = S7.GetBitAt(buffer0, 9, 5);
                    R155 = S7.GetBitAt(buffer0, 9, 6);
                    R156 = S7.GetBitAt(buffer0, 9, 7); 
                    R157 = S7.GetBitAt(buffer0, 10, 0);
                    R158 = S7.GetBitAt(buffer0, 10, 1);
                    R159 = S7.GetBitAt(buffer0, 10, 2);
                    R1510 = S7.GetBitAt(buffer0, 10, 3);
                    R1511 = S7.GetBitAt(buffer0, 10, 4);
                    R1512 = S7.GetBitAt(buffer0, 10, 5);
                    R1513 = S7.GetBitAt(buffer0, 10, 6);
                    R1514 = S7.GetBitAt(buffer0, 10, 7);
                    R1515 = S7.GetBitAt(buffer0, 11, 0);
                    R1516 = S7.GetBitAt(buffer0, 11, 1);
                    R1517 = S7.GetBitAt(buffer0, 11, 2);
                    R1518 = S7.GetBitAt(buffer0, 11, 3);
                }

               // ONLY ONE Bit

               /* var buffer = new byte[90];
                int result = _client.DBRead(5, 0, buffer.Length, buffer);
                if (result == 0)
                {
                    R111  = S7.GetBitAt(buffer, 0, 2);*/
                        //R112 = S7.GetBitAt(buffer, 0, 3);
              //}
                    else
                    {
                    Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\t Read error: " + _client.ErrorText(result0));
                }
            }
        }

        /// <summary>
        /// Writes a bit at the specified address. Es.: DB1.DBX10.2 writes the bit in db 1, word 10, 3rd bit
        /// </summary>
        /// <param name="address">Es.: DB1.DBX10.2 writes the bit in db 1, word 10, 3rd bit</param>
        /// <param name="value">true or false</param>
        /// <returns></returns>

        private int WriteBit(string address, bool value)
        {
            var strings = address.Split('.');
            int db = Convert.ToInt32(strings[0].Replace("DB", ""));
            int pos = Convert.ToInt32(strings[1].Replace("DBX", ""));
            int bit = Convert.ToInt32(strings[2]);
            return WriteBit(db, pos, bit, value);
        }

        private int WriteBit(int db, int pos, int bit, bool value)
        {
            lock (_locker)
            {
                var buffer = new byte[1];
                S7.SetBitAt(ref buffer, 0, bit, value);
                return _client.WriteArea(S7Consts.S7AreaDB, db, pos + bit, buffer.Length, S7Consts.S7WLBit, buffer);
            }
        }

        private void OnValuesRefreshed()
        {
            ValuesRefreshed?.Invoke(this, new EventArgs());
        }
    }
}
