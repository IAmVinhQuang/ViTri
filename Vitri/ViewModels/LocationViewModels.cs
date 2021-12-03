using HMI.PlcServices;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Vitri.ViewModels
{
    class LocationViewModels : BindableBase
    { 
        public string IpAddress
        {
            get { return _ipAddress; }
            set { SetProperty(ref _ipAddress, value); }
        }
        private string _ipAddress;

        public bool R121
        {
            get { return _r121; }
            set { SetProperty(ref _r121, value); }
        }        private bool _r121;
        public bool R122
        {
            get { return _r122; }
            set { SetProperty(ref _r122, value); }
        }        private bool _r122;
        public bool R123
        {
            get { return _r123; }
            set { SetProperty(ref _r123, value); }
        }        private bool _r123;
        public bool R124
        {
            get { return _r124; }
            set { SetProperty(ref _r124, value); }
        }        private bool _r124;
        public bool R125
        {
            get { return _r125; }
            set { SetProperty(ref _r125, value); }
        }        private bool _r125;
        public bool R126
        {
            get { return _r126; }
            set { SetProperty(ref _r126, value); }
        }        private bool _r126;
        public bool R127
        {
            get { return _r127; }
            set { SetProperty(ref _r127, value); }
        }        private bool _r127;
        public bool R128
        {
            get { return _r128; }
            set { SetProperty(ref _r128, value); }
        }        private bool _r128;
        public bool R129
        {
            get { return _r129; }
            set { SetProperty(ref _r129, value); }
        }        private bool _r129;
        public bool R1210
        {
            get { return _r1210; }
            set { SetProperty(ref _r1210, value); }
        }        private bool _r1210;
        public bool R1211
        {
            get { return _r1211; }
            set { SetProperty(ref _r1211, value); }
        }        private bool _r1211;
        public bool R1212
        {
            get { return _r1212; }
            set { SetProperty(ref _r1212, value); }
        }        private bool _r1212;
        public bool R1213
        {
            get { return _r1213; }
            set { SetProperty(ref _r1213, value); }
        }        private bool _r1213;
        public bool R1214
        {
            get { return _r1214; }
            set { SetProperty(ref _r1214, value); }
        }        private bool _r1214;
        public bool R1215
        {
            get { return _r1215; }
            set { SetProperty(ref _r1215, value); }
        }        private bool _r1215;
        public bool R1216
        {
            get { return _r1216; }
            set { SetProperty(ref _r1216, value); }
        }        private bool _r1216;
        public bool R1217
        {
            get { return _r1217; }
            set { SetProperty(ref _r1217, value); }
        }        private bool _r1217;
        public bool R1218
        {
            get { return _r1218; }
            set { SetProperty(ref _r1218, value); }
        }        private bool _r1218;
        public bool R111
        {
            get { return _r111; }
            set { SetProperty(ref _r111, value); }
        }        private bool _r111;
        public bool R112
        {
            get { return _r112; }
            set { SetProperty(ref _r112, value); }
        }        private bool _r112;
        public bool R113
        {
            get { return _r113; }
            set { SetProperty(ref _r113, value); }
        }        private bool _r113;
        public bool R114
        {
            get { return _r114; }
            set { SetProperty(ref _r114, value); }
        }        private bool _r114;
        public bool R115
        {
            get { return _r115; }
            set { SetProperty(ref _r115, value); }
        }        private bool _r115;
        public bool R116
        {
            get { return _r116; }
            set { SetProperty(ref _r116, value); }
        }        private bool _r116;
        public bool R117
        {
            get { return _r117; }
            set { SetProperty(ref _r117, value); }
        }        private bool _r117;
        public bool R118
        {
            get { return _r118; }
            set { SetProperty(ref _r118, value); }
        }        private bool _r118;
        public bool R119
        {
            get { return _r119; }
            set { SetProperty(ref _r119, value); }
        }        private bool _r119;
        public bool R1110
        {
            get { return _r1110; }
            set { SetProperty(ref _r1110, value); }
        }        private bool _r1110;
        public bool R1111
        {
            get { return _r1111; }
            set { SetProperty(ref _r1111, value); }
        }        private bool _r1111;
        public bool R1112
        {
            get { return _r1112; }
            set { SetProperty(ref _r1112, value); }
        }        private bool _r1112;
        public bool R1113
        {
            get { return _r1113; }
            set { SetProperty(ref _r1113, value); }
        }        private bool _r1113;
        public bool R1114
        {
            get { return _r1114; }
            set { SetProperty(ref _r1114, value); }
        }        private bool _r1114;
        public bool R1115
        {
            get { return _r1115; }
            set { SetProperty(ref _r1115, value); }
        }        private bool _r1115;
        public bool R1116
        {
            get { return _r1116; }
            set { SetProperty(ref _r1116, value); }
        }        private bool _r1116;
        public bool R1117
        {
            get { return _r1117; }
            set { SetProperty(ref _r1117, value); }
        }        private bool _r1117;
        public bool R1118
        {
            get { return _r1118; }
            set { SetProperty(ref _r1118, value); }
        }        private bool _r1118;
        public bool R131
        {
            get { return _r131; }
            set { SetProperty(ref _r131, value); }
        }        private bool _r131;
        public bool R132
        {
            get { return _r132; }
            set { SetProperty(ref _r132, value); }
        }        private bool _r132;
        public bool R133
        {
            get { return _r133; }
            set { SetProperty(ref _r133, value); }
        }        private bool _r133;
        public bool R134
        {
            get { return _r134; }
            set { SetProperty(ref _r134, value); }
        }        private bool _r134;
        public bool R135
        {
            get { return _r135; }
            set { SetProperty(ref _r135, value); }
        }        private bool _r135;
        public bool R136
        {
            get { return _r136; }
            set { SetProperty(ref _r136, value); }
        }        private bool _r136;
        public bool R137
        {
            get { return _r137; }
            set { SetProperty(ref _r137, value); }
        }        private bool _r137;
        public bool R138
        {
            get { return _r138; }
            set { SetProperty(ref _r138, value); }
        }        private bool _r138;
        public bool R139
        {
            get { return _r139; }
            set { SetProperty(ref _r139, value); }
        }        private bool _r139;
        public bool R1310
        {
            get { return _r1310; }
            set { SetProperty(ref _r1310, value); }
        }        private bool _r1310;
        public bool R1311
        {
            get { return _r1311; }
            set { SetProperty(ref _r1311, value); }
        }        private bool _r1311;
        public bool R1312
        {
            get { return _r1312; }
            set { SetProperty(ref _r1312, value); }
        }        private bool _r1312;
        public bool R1313
        {
            get { return _r1313; }
            set { SetProperty(ref _r1313, value); }
        }        private bool _r1313;
        public bool R1314
        {
            get { return _r1314; }
            set { SetProperty(ref _r1314, value); }
        }        private bool _r1314;
        public bool R1315
        {
            get { return _r1315; }
            set { SetProperty(ref _r1315, value); }
        }        private bool _r1315;
        public bool R1316
        {
            get { return _r1316; }
            set { SetProperty(ref _r1316, value); }
        }        private bool _r1316;
        public bool R1317
        {
            get { return _r1317; }
            set { SetProperty(ref _r1317, value); }
        }        private bool _r1317;
        public bool R1318
        {
            get { return _r1318; }
            set { SetProperty(ref _r1318, value); }
        }        private bool _r1318;
        public bool R141
        {
            get { return _r141; }
            set { SetProperty(ref _r141, value); }
        }        private bool _r141;
        public bool R142
        {
            get { return _r142; }
            set { SetProperty(ref _r142, value); }
        }        private bool _r142;
        public bool R143
        {
            get { return _r143; }
            set { SetProperty(ref _r143, value); }
        }        private bool _r143;
        public bool R144
        {
            get { return _r144; }
            set { SetProperty(ref _r144, value); }
        }        private bool _r144;
        public bool R145
        {
            get { return _r145; }
            set { SetProperty(ref _r145, value); }
        }        private bool _r145;
        public bool R146
        {
            get { return _r146; }
            set { SetProperty(ref _r146, value); }
        }        private bool _r146;
        public bool R147
        {
            get { return _r147; }
            set { SetProperty(ref _r147, value); }
        }        private bool _r147;
        public bool R148
        {
            get { return _r148; }
            set { SetProperty(ref _r148, value); }
        }        private bool _r148;
        public bool R149
        {
            get { return _r149; }
            set { SetProperty(ref _r149, value); }
        }        private bool _r149;
        public bool R1410
        {
            get { return _r1410; }
            set { SetProperty(ref _r1410, value); }
        }        private bool _r1410;
        public bool R1411
        {
            get { return _r1411; }
            set { SetProperty(ref _r1411, value); }
        }        private bool _r1411;
        public bool R1412
        {
            get { return _r1412; }
            set { SetProperty(ref _r1412, value); }
        }        private bool _r1412;
        public bool R1413
        {
            get { return _r1413; }
            set { SetProperty(ref _r1413, value); }
        }        private bool _r1413;
        public bool R1414
        {
            get { return _r1414; }
            set { SetProperty(ref _r1414, value); }
        }        private bool _r1414;
        public bool R1415
        {
            get { return _r1415; }
            set { SetProperty(ref _r1415, value); }
        }        private bool _r1415;
        public bool R1416
        {
            get { return _r1416; }
            set { SetProperty(ref _r1416, value); }
        }        private bool _r1416;
        public bool R1417
        {
            get { return _r1417; }
            set { SetProperty(ref _r1417, value); }
        }        private bool _r1417;
        public bool R1418
        {
            get { return _r1418; }
            set { SetProperty(ref _r1418, value); }
        }        private bool _r1418;
        public bool R151
        {
            get { return _r151; }
            set { SetProperty(ref _r151, value); }
        }        private bool _r151;
        public bool R152
        {
            get { return _r152; }
            set { SetProperty(ref _r152, value); }
        }        private bool _r152;
        public bool R153
        {
            get { return _r153; }
            set { SetProperty(ref _r153, value); }
        }        private bool _r153;
        public bool R154
        {
            get { return _r154; }
            set { SetProperty(ref _r154, value); }
        }        private bool _r154;
        public bool R155
        {
            get { return _r155; }
            set { SetProperty(ref _r155, value); }
        }        private bool _r155;
        public bool R156
        {
            get { return _r156; }
            set { SetProperty(ref _r156, value); }
        }        private bool _r156;
        public bool R157
        {
            get { return _r157; }
            set { SetProperty(ref _r157, value); }
        }        private bool _r157;
        public bool R158
        {
            get { return _r158; }
            set { SetProperty(ref _r158, value); }
        }        private bool _r158;
        public bool R159
        {
            get { return _r159; }
            set { SetProperty(ref _r159, value); }
        }        private bool _r159;
        public bool R1510
        {
            get { return _r1510; }
            set { SetProperty(ref _r1510, value); }
        }        private bool _r1510;
        public bool R1511
        {
            get { return _r1511; }
            set { SetProperty(ref _r1511, value); }
        }        private bool _r1511;
        public bool R1512
        {
            get { return _r1512; }
            set { SetProperty(ref _r1512, value); }
        }        private bool _r1512;
        public bool R1513
        {
            get { return _r1513; }
            set { SetProperty(ref _r1513, value); }
        }        private bool _r1513;
        public bool R1514
        {
            get { return _r1514; }
            set { SetProperty(ref _r1514, value); }
        }        private bool _r1514;
        public bool R1515
        {
            get { return _r1515; }
            set { SetProperty(ref _r1515, value); }
        }        private bool _r1515;
        public bool R1516
        {
            get { return _r1516; }
            set { SetProperty(ref _r1516, value); }
        }        private bool _r1516;
        public bool R1517
        {
            get { return _r1517; }
            set { SetProperty(ref _r1517, value); }
        }        private bool _r1517;
        public bool R1518
        {
            get { return _r1518; }
            set { SetProperty(ref _r1518, value); }
        }        private bool _r1518;
        public bool R211
        {
            get { return _r211; }
            set { SetProperty(ref _r211, value); }
        }        private bool _r211;
        public bool R212
        {
            get { return _r212; }
            set { SetProperty(ref _r212, value); }
        }        private bool _r212;
        public bool R213
        {
            get { return _r213; }
            set { SetProperty(ref _r213, value); }
        }        private bool _r213;
        public bool R214
        {
            get { return _r214; }
            set { SetProperty(ref _r214, value); }
        }        private bool _r214;
        public bool R215
        {
            get { return _r215; }
            set { SetProperty(ref _r215, value); }
        }        private bool _r215;
        public bool R216
        {
            get { return _r216; }
            set { SetProperty(ref _r216, value); }
        }        private bool _r216;
        public bool R217
        {
            get { return _r217; }
            set { SetProperty(ref _r217, value); }
        }        private bool _r217;
        public bool R218
        {
            get { return _r218; }
            set { SetProperty(ref _r218, value); }
        }        private bool _r218;
        public bool R219
        {
            get { return _r219; }
            set { SetProperty(ref _r219, value); }
        }        private bool _r219;
        public bool R2110
        {
            get { return _r2110; }
            set { SetProperty(ref _r2110, value); }
        }        private bool _r2110;
        public bool R2111
        {
            get { return _r2111; }
            set { SetProperty(ref _r2111, value); }
        }        private bool _r2111;
        public bool R2112
        {
            get { return _r2112; }
            set { SetProperty(ref _r2112, value); }
        }        private bool _r2112;
        public bool R2113
        {
            get { return _r2113; }
            set { SetProperty(ref _r2113, value); }
        }        private bool _r2113;
        public bool R2114
        {
            get { return _r2114; }
            set { SetProperty(ref _r2114, value); }
        }        private bool _r2114;
        public bool R2115
        {
            get { return _r2115; }
            set { SetProperty(ref _r2115, value); }
        }        private bool _r2115;
        public bool R2116
        {
            get { return _r2116; }
            set { SetProperty(ref _r2116, value); }
        }        private bool _r2116;
        public bool R12117
        {
            get { return _r2117; }
            set { SetProperty(ref _r2117, value); }
        }        private bool _r2117;
        public bool R2118
        {
            get { return _r2118; }
            set { SetProperty(ref _r2118, value); }
        }        private bool _r2118;

        
        public ConnectionStates ConnectionState
        {
            get { return _connectionState; }
            set { SetProperty(ref _connectionState, value); }
        }
        private ConnectionStates _connectionState;

        public TimeSpan ScanTime
        {
            get { return _scanTime; }
            set { SetProperty(ref _scanTime, value); }
        }
        private TimeSpan _scanTime;

        public ICommand ConnectCommand { get; private set; }
        public ICommand DisconnectCommand { get; private set; }       
        public ICommand R111Command { get; private set; }
        public ICommand R112Command { get; private set; }
        public ICommand R113Command { get; private set; }
        public ICommand R114Command { get; private set; }
        public ICommand R115Command { get; private set; }
        public ICommand R116Command { get; private set; }
        public ICommand R117Command { get; private set; }
        public ICommand R118Command { get; private set; }
        public ICommand R119Command { get; private set; }
        public ICommand R1110Command { get; private set; }
        public ICommand R1111Command { get; private set; }
        public ICommand R1112Command { get; private set; }
        public ICommand R1113Command { get; private set; }
        public ICommand R1114Command { get; private set; }
        public ICommand R1115Command { get; private set; }
        public ICommand R1116Command { get; private set; }
        public ICommand R1117Command { get; private set; }
        public ICommand R1118Command { get; private set; }

        public ICommand R121Command { get; private set; }
        public ICommand R122Command { get; private set; }
        public ICommand R123Command { get; private set; }
        public ICommand R124Command { get; private set; }
        public ICommand R125Command { get; private set; }
        public ICommand R126Command { get; private set; }
        public ICommand R127Command { get; private set; }
        public ICommand R128Command { get; private set; }
        public ICommand R129Command { get; private set; }
        public ICommand R1210Command { get; private set; }
        public ICommand R1211Command { get; private set; }
        public ICommand R1212Command { get; private set; }
        public ICommand R1213Command { get; private set; }
        public ICommand R1214Command { get; private set; }
        public ICommand R1215Command { get; private set; }
        public ICommand R1216Command { get; private set; }
        public ICommand R1217Command { get; private set; }
        public ICommand R1218Command { get; private set; }

        public ICommand R131Command { get; private set; }
        public ICommand R132Command { get; private set; }
        public ICommand R133Command { get; private set; }
        public ICommand R134Command { get; private set; }
        public ICommand R135Command { get; private set; }
        public ICommand R136Command { get; private set; }
        public ICommand R137Command { get; private set; }
        public ICommand R138Command { get; private set; }
        public ICommand R139Command { get; private set; }
        public ICommand R1310Command { get; private set; }
        public ICommand R1311Command { get; private set; }
        public ICommand R1312Command { get; private set; }
        public ICommand R1313Command { get; private set; }
        public ICommand R1314Command { get; private set; }
        public ICommand R1315Command { get; private set; }
        public ICommand R1316Command { get; private set; }
        public ICommand R1317Command { get; private set; }
        public ICommand R1318Command { get; private set; }

        public ICommand R141Command { get; private set; }
        public ICommand R142Command { get; private set; }
        public ICommand R143Command { get; private set; }
        public ICommand R144Command { get; private set; }
        public ICommand R145Command { get; private set; }
        public ICommand R146Command { get; private set; }
        public ICommand R147Command { get; private set; }
        public ICommand R148Command { get; private set; }
        public ICommand R149Command { get; private set; }
        public ICommand R1410Command { get; private set; }
        public ICommand R1411Command { get; private set; }
        public ICommand R1412Command { get; private set; }
        public ICommand R1413Command { get; private set; }
        public ICommand R1414Command { get; private set; }
        public ICommand R1415Command { get; private set; }
        public ICommand R1416Command { get; private set; }
        public ICommand R1417Command { get; private set; }
        public ICommand R1418Command { get; private set; }

        public ICommand R151Command { get; private set; }
        public ICommand R152Command { get; private set; }
        public ICommand R153Command { get; private set; }
        public ICommand R154Command { get; private set; }
        public ICommand R155Command { get; private set; }
        public ICommand R156Command { get; private set; }
        public ICommand R157Command { get; private set; }
        public ICommand R158Command { get; private set; }
        public ICommand R159Command { get; private set; }
        public ICommand R1510Command { get; private set; }
        public ICommand R1511Command { get; private set; }
        public ICommand R1512Command { get; private set; }
        public ICommand R1513Command { get; private set; }
        public ICommand R1514Command { get; private set; }
        public ICommand R1515Command { get; private set; }
        public ICommand R1516Command { get; private set; }
        public ICommand R1517Command { get; private set; }
        public ICommand R1518Command { get; private set; }



        S7PlcServices _plcService;

        // Vì sử dụng Refenrence: Prism nên ICommand sẽ là DelegateCommand. Nếu sử dụng Reference khác thì ICommand sẽ khác nhé: Ex: MVVM Light: RelayCommand
        public LocationViewModels()
        {
            _plcService = new S7PlcServices();
            ConnectCommand = new DelegateCommand(Connect);
            DisconnectCommand = new DelegateCommand(Disconnect);         
            R111Command = new DelegateCommand(async () => { await SR111(); });
            R112Command = new DelegateCommand(async () => { await SR112(); });
            R113Command = new DelegateCommand(async () => { await SR113(); });
            R114Command = new DelegateCommand(async () => { await SR114(); });
            R115Command = new DelegateCommand(async () => { await SR115(); });
            R116Command = new DelegateCommand(async () => { await SR116(); });
            R117Command = new DelegateCommand(async () => { await SR117(); });
            R118Command = new DelegateCommand(async () => { await SR118(); });
            R119Command = new DelegateCommand(async () => { await SR119(); });
            R1110Command  = new DelegateCommand(async () => { await SR1110(); });
            R1111Command  = new DelegateCommand(async () => { await SR1111(); });
            R1112Command  = new DelegateCommand(async () => { await SR1112(); });
            R1113Command  = new DelegateCommand(async () => { await SR1113(); });
            R1114Command  = new DelegateCommand(async () => { await SR1114(); });
            R1115Command  = new DelegateCommand(async () => { await SR1115(); });
            R1116Command  = new DelegateCommand(async () => { await SR1116(); });
            R1117Command  = new DelegateCommand(async () => { await SR1117(); });
            R1118Command  = new DelegateCommand(async () => { await SR1118(); });

            R121Command = new DelegateCommand(async () => { await SR121(); });
            R122Command = new DelegateCommand(async () => { await SR122(); });
            R123Command = new DelegateCommand(async () => { await SR123(); });
            R124Command = new DelegateCommand(async () => { await SR124(); });
            R125Command = new DelegateCommand(async () => { await SR125(); });
            R126Command = new DelegateCommand(async () => { await SR126(); });
            R127Command = new DelegateCommand(async () => { await SR127(); });
            R128Command = new DelegateCommand(async () => { await SR128(); });
            R129Command = new DelegateCommand(async () => { await SR129(); });
            R1210Command = new DelegateCommand(async () => { await SR1210(); });
            R1211Command = new DelegateCommand(async () => { await SR1211(); });
            R1212Command = new DelegateCommand(async () => { await SR1212(); });
            R1213Command = new DelegateCommand(async () => { await SR1213(); });
            R1214Command = new DelegateCommand(async () => { await SR1214(); });
            R1215Command = new DelegateCommand(async () => { await SR1215(); });
            R1216Command = new DelegateCommand(async () => { await SR1216(); });
            R1217Command = new DelegateCommand(async () => { await SR1217(); });
            R1218Command = new DelegateCommand(async () => { await SR1218(); });

            R131Command = new DelegateCommand(async () => { await SR131(); });
            R132Command = new DelegateCommand(async () => { await SR132(); });
            R133Command = new DelegateCommand(async () => { await SR133(); });
            R134Command = new DelegateCommand(async () => { await SR134(); });
            R135Command = new DelegateCommand(async () => { await SR135(); });
            R136Command = new DelegateCommand(async () => { await SR136(); });
            R137Command = new DelegateCommand(async () => { await SR137(); });
            R138Command = new DelegateCommand(async () => { await SR138(); });
            R139Command = new DelegateCommand(async () => { await SR139(); });
            R1310Command = new DelegateCommand(async () => { await SR1310(); });
            R1311Command = new DelegateCommand(async () => { await SR1311(); });
            R1312Command = new DelegateCommand(async () => { await SR1312(); });
            R1313Command = new DelegateCommand(async () => { await SR1313(); });
            R1314Command = new DelegateCommand(async () => { await SR1314(); });
            R1315Command = new DelegateCommand(async () => { await SR1315(); });
            R1316Command = new DelegateCommand(async () => { await SR1316(); });
            R1317Command = new DelegateCommand(async () => { await SR1317(); });
            R1318Command = new DelegateCommand(async () => { await SR1318(); });

            R141Command = new DelegateCommand(async () => { await SR141(); });
            R142Command = new DelegateCommand(async () => { await SR142(); });
            R143Command = new DelegateCommand(async () => { await SR143(); });
            R144Command = new DelegateCommand(async () => { await SR144(); });
            R145Command = new DelegateCommand(async () => { await SR145(); });
            R146Command = new DelegateCommand(async () => { await SR146(); });
            R147Command = new DelegateCommand(async () => { await SR147(); });
            R148Command = new DelegateCommand(async () => { await SR148(); });
            R149Command = new DelegateCommand(async () => { await SR149(); });
            R1410Command = new DelegateCommand(async () => { await SR1410(); });
            R1411Command = new DelegateCommand(async () => { await SR1411(); });
            R1412Command = new DelegateCommand(async () => { await SR1412(); });
            R1413Command = new DelegateCommand(async () => { await SR1413(); });
            R1414Command = new DelegateCommand(async () => { await SR1414(); });
            R1415Command = new DelegateCommand(async () => { await SR1415(); });
            R1416Command = new DelegateCommand(async () => { await SR1416(); });
            R1417Command = new DelegateCommand(async () => { await SR1417(); });
            R1418Command = new DelegateCommand(async () => { await SR1418(); });

            R151Command = new DelegateCommand(async () => { await SR151(); });
            R152Command = new DelegateCommand(async () => { await SR152(); });
            R153Command = new DelegateCommand(async () => { await SR153(); });
            R154Command = new DelegateCommand(async () => { await SR154(); });
            R155Command = new DelegateCommand(async () => { await SR155(); });
            R156Command = new DelegateCommand(async () => { await SR156(); });
            R157Command = new DelegateCommand(async () => { await SR157(); });
            R158Command = new DelegateCommand(async () => { await SR158(); });
            R159Command = new DelegateCommand(async () => { await SR159(); });
            R1510Command = new DelegateCommand(async () => { await SR1510(); });
            R1511Command = new DelegateCommand(async () => { await SR1511(); });
            R1512Command = new DelegateCommand(async () => { await SR1512(); });
            R1513Command = new DelegateCommand(async () => { await SR1513(); });
            R1514Command = new DelegateCommand(async () => { await SR1514(); });
            R1515Command = new DelegateCommand(async () => { await SR1515(); });
            R1516Command = new DelegateCommand(async () => { await SR1516(); });
            R1517Command = new DelegateCommand(async () => { await SR1517(); });
            R1518Command = new DelegateCommand(async () => { await SR1518(); });


            IpAddress = "127.0.0.1";
            OnPlcServiceValuesRefreshed(null, null);
            _plcService.ValuesRefreshed += OnPlcServiceValuesRefreshed;
        }

        private void OnPlcServiceValuesRefreshed(object sender, EventArgs e)
        {
            ConnectionState = _plcService.ConnectionState;

            R111 = _plcService.R111;
            R112 = _plcService.R112;
            R113 = _plcService.R113;
            R114 = _plcService.R114;
            R115 = _plcService.R115;
            R116 = _plcService.R116;
            R117 = _plcService.R117;
            R118 = _plcService.R118;
            R119 = _plcService.R119;
            R1110 = _plcService.R1110;
            R1111 = _plcService.R1111;
            R1112 = _plcService.R1112;
            R1113 = _plcService.R1113;
            R1114 = _plcService.R1114;
            R1115 = _plcService.R1115;
            R1116 = _plcService.R1116;
            R1117 = _plcService.R1117;
            R1118 = _plcService.R1118;

            R121 = _plcService.R121;
            R122 = _plcService.R122;
            R123 = _plcService.R123;
            R124 = _plcService.R124;
            R125 = _plcService.R125;
            R126 = _plcService.R126;
            R127 = _plcService.R127;
            R128 = _plcService.R128;
            R129 = _plcService.R129;
            R1210 = _plcService.R1210;
            R1211 = _plcService.R1211;
            R1212 = _plcService.R1212;
            R1213 = _plcService.R1213;
            R1214 = _plcService.R1214;
            R1215 = _plcService.R1215;
            R1216 = _plcService.R1216;
            R1217 = _plcService.R1217;
            R1218 = _plcService.R1218;

            R131   = _plcService.R131;
            R132   = _plcService.R132;
            R133   = _plcService.R133;
            R134   = _plcService.R134;
            R135   = _plcService.R135;
            R136   = _plcService.R136;
            R137   = _plcService.R137;
            R138   = _plcService.R138;
            R139   = _plcService.R139;
            R1310  = _plcService.R1310;
            R1311  = _plcService.R1311;
            R1312  = _plcService.R1312;
            R1313  = _plcService.R1313;
            R1314  = _plcService.R1314;
            R1315  = _plcService.R1315;
            R1316  = _plcService.R1316;
            R1317  = _plcService.R1317;
            R1318  = _plcService.R1318;

            R141 = _plcService.R141;
            R142 = _plcService.R142;
            R143 = _plcService.R143;
            R144 = _plcService.R144;
            R145 = _plcService.R145;
            R146 = _plcService.R146;
            R147 = _plcService.R147;
            R148 = _plcService.R148;
            R149 = _plcService.R149;
            R1410 = _plcService.R1410;
            R1411 = _plcService.R1411;
            R1412 = _plcService.R1412;
            R1413 = _plcService.R1413;
            R1414 = _plcService.R1414;
            R1415 = _plcService.R1415;
            R1416 = _plcService.R1416;
            R1417 = _plcService.R1417;
            R1418 = _plcService.R1418;

            R151 = _plcService.R151;
            R152 = _plcService.R152;
            R153 = _plcService.R153;
            R154 = _plcService.R154;
            R155 = _plcService.R155;
            R156 = _plcService.R156;
            R157 = _plcService.R157;
            R158 = _plcService.R158;
            R159 = _plcService.R159;
            R1510 = _plcService.R1510;
            R1511 = _plcService.R1511;
            R1512 = _plcService.R1512;
            R1513 = _plcService.R1513;
            R1514 = _plcService.R1514;
            R1515 = _plcService.R1515;
            R1516 = _plcService.R1516;
            R1517 = _plcService.R1517;
            R1518 = _plcService.R1518;

            ScanTime = _plcService.ScanTime;
        }

        private async Task SR111()
        {
            await _plcService.WriteButton("DB1.DBX0.0");
        }
        private async Task SR112()
        {
            await _plcService.WriteButton("DB1.DBX0.1");
        }
        private async Task SR113()
        {
            await _plcService.WriteButton("DB1.DBX0.2");
        }
        private async Task SR114()
        {
            await _plcService.WriteButton("DB1.DBX0.3");
        }
        private async Task SR115()
        {
            await _plcService.WriteButton("DB1.DBX0.4");
        }
        private async Task SR116()
        {
            await _plcService.WriteButton("DB1.DBX0.5");
        }
        private async Task SR117()
        {
            await _plcService.WriteButton("DB1.DBX0.6");
        }
        private async Task SR118()
        {
            await _plcService.WriteButton("DB1.DBX0.7");
        }
        private async Task SR119()
        {
            await _plcService.WriteButton("DB3.DBX0.0");
        }
        private async Task SR1110()
        {
            await _plcService.WriteButton("DB3.DBX0.1");
        }                                    
        private async Task SR1111()
        {                                    
            await _plcService.WriteButton("DB3.DBX0.2");
        }                                    
        private async Task SR1112()
        {                                    
            await _plcService.WriteButton("DB3.DBX0.3");
        }                                    
        private async Task SR1113()
        {                                    
            await _plcService.WriteButton("DB3.DBX0.4");
        }                                    
        private async Task SR1114()
        {                                    
            await _plcService.WriteButton("DB3.DBX0.5");
        }                                    
        private async Task SR1115()
        {                                    
            await _plcService.WriteButton("DB3.DBX0.6");
        }                                    
        private async Task SR1116()
        {                                    
            await _plcService.WriteButton("DB3.DBX0.7");
        }
        private async Task SR1117()
        {
            await _plcService.WriteButton("DB6.DBX0.0");
        }
        private async Task SR1118()
        {
            await _plcService.WriteButton("DB6.DBX0.1");
        }
        private async Task SR121()
        {
            await _plcService.WriteButton("DB6.DBX0.2");
        }
        private async Task SR122()
        {
            await _plcService.WriteButton("DB6.DBX0.3");
        }
        private async Task SR123()
        {
            await _plcService.WriteButton("DB6.DBX0.4");
        }
        private async Task SR124()
        {
            await _plcService.WriteButton("DB6.DBX0.5");
        }
        private async Task SR125()
        {
            await _plcService.WriteButton("DB6.DBX0.6");
        }
        private async Task SR126()
        {
            await _plcService.WriteButton("DB6.DBX0.7");
        }
        private async Task SR127()
        {
            await _plcService.WriteButton("DB7.DBX0.0");
        }
        private async Task SR128()
        {
            await _plcService.WriteButton("DB7.DBX0.1");
        }
        private async Task SR129()
        {
            await _plcService.WriteButton("DB7.DBX0.2");
        }
        private async Task SR1210()
        {
            await _plcService.WriteButton("DB7.DBX0.3");
        }
        private async Task SR1211()
        {
            await _plcService.WriteButton("DB7.DBX0.4");
        }
        private async Task SR1212()
        {
            await _plcService.WriteButton("DB7.DBX0.5");
        }
        private async Task SR1213()
        {
            await _plcService.WriteButton("DB7.DBX0.6");
        }
        private async Task SR1214()
        {
            await _plcService.WriteButton("DB7.DBX0.7");
        }
        private async Task SR1215()
        {
            await _plcService.WriteButton("DB8.DBX0.0");
        }
        private async Task SR1216()
        {
            await _plcService.WriteButton("DB8.DBX0.1");
        }
        private async Task SR1217()
        {
            await _plcService.WriteButton("DB8.DBX0.2");
        }
        private async Task SR1218()
        {
            await _plcService.WriteButton("DB8.DBX0.3");
        }
        private async Task SR131()
        {
            await _plcService.WriteButton("DB8.DBX0.4");
        }
        private async Task SR132()
        {
            await _plcService.WriteButton("DB8.DBX0.5");
        }
        private async Task SR133()
        {
            await _plcService.WriteButton("DB8.DBX0.6");
        }
        private async Task SR134()
        {
            await _plcService.WriteButton("DB8.DBX0.7");
        }
        private async Task SR135()
        {
            await _plcService.WriteButton("DB9.DBX0.0");
        }
        private async Task SR136()
        {
            await _plcService.WriteButton("DB9.DBX0.1");
        }
        private async Task SR137()
        {
            await _plcService.WriteButton("DB9.DBX0.2");
        }
        private async Task SR138()
        {
            await _plcService.WriteButton("DB9.DBX0.3");
        }
        private async Task SR139()
        {
            await _plcService.WriteButton("DB9.DBX0.4");
        }
        private async Task SR1310()
        {
            await _plcService.WriteButton("DB9.DBX0.5");
        }
        private async Task SR1311()
        {
            await _plcService.WriteButton("DB9.DBX0.6");
        }
        private async Task SR1312()
        {
            await _plcService.WriteButton("DB9.DBX0.7");
        }
        private async Task SR1313()
        {
            await _plcService.WriteButton("DB85.DBX0.0");
        }
        private async Task SR1314()
        {
            await _plcService.WriteButton("DB85.DBX0.1");
        }
        private async Task SR1315()
        {
            await _plcService.WriteButton("DB85.DBX0.2");
        }
        private async Task SR1316()
        {
            await _plcService.WriteButton("DB85.DBX0.3");
        }
        private async Task SR1317()
        {
            await _plcService.WriteButton("DB85.DBX0.4");
        }
        private async Task SR1318()
        {
            await _plcService.WriteButton("DB85.DBX0.5");
        }
        private async Task SR141()
        {
            await _plcService.WriteButton("DB85.DBX0.6");
        }
        private async Task SR142()
        {
            await _plcService.WriteButton("DB85.DBX0.7");
        }
        private async Task SR143()
        {
            await _plcService.WriteButton("DB86.DBX0.0");
        }
        private async Task SR144()
        {
            await _plcService.WriteButton("DB86.DBX0.1");
        }
        private async Task SR145()
        {
            await _plcService.WriteButton("DB86.DBX0.2");
        }
        private async Task SR146()
        {
            await _plcService.WriteButton("DB86.DBX0.3");
        }
        private async Task SR147()
        {
            await _plcService.WriteButton("DB86.DBX0.4");
        }
        private async Task SR148()
        {
            await _plcService.WriteButton("DB86.DBX0.5");
        }
        private async Task SR149()
        {
            await _plcService.WriteButton("DB86.DBX0.6");
        }
        private async Task SR1410()
        {
            await _plcService.WriteButton("DB86.DBX0.7");
        }
        private async Task SR1411()
        {
            await _plcService.WriteButton("DB87.DBX0.0");
        }
        private async Task SR1412()
        {
            await _plcService.WriteButton("DB87.DBX0.1");
        }
        private async Task SR1413()
        {
            await _plcService.WriteButton("DB87.DBX0.2");
        }
        private async Task SR1414()
        {
            await _plcService.WriteButton("DB87.DBX0.3");
        }
        private async Task SR1415()
        {
            await _plcService.WriteButton("DB87.DBX0.4");
        }
        private async Task SR1416()
        {
            await _plcService.WriteButton("DB87.DBX0.5");
        }
        private async Task SR1417()
        {
            await _plcService.WriteButton("DB87.DBX0.6");
        }
        private async Task SR1418()
        {
            await _plcService.WriteButton("DB87.DBX0.7");
        }
        private async Task SR151()
        {
            await _plcService.WriteButton("DB88.DBX0.0");
        }
        private async Task SR152()
        {
            await _plcService.WriteButton("DB88.DBX0.1");
        }
        private async Task SR153()
        {
            await _plcService.WriteButton("DB88.DBX0.2");
        }
        private async Task SR154()
        {
            await _plcService.WriteButton("DB88.DBX0.3");
        }
        private async Task SR155()
        {
            await _plcService.WriteButton("DB88.DBX0.4");
        }
        private async Task SR156()
        {
            await _plcService.WriteButton("DB88.DBX0.5");
        }
        private async Task SR157()
        {
            await _plcService.WriteButton("DB88.DBX0.6");
        }
        private async Task SR158()
        {
            await _plcService.WriteButton("DB88.DBX0.7");
        }
        private async Task SR159()
        {
            await _plcService.WriteButton("DB89.DBX0.0");
        }
        private async Task SR1510()
        {
            await _plcService.WriteButton("DB89.DBX0.1");
        }
        private async Task SR1511()
        {
            await _plcService.WriteButton("DB89.DBX0.2");
        }
        private async Task SR1512()
        {
            await _plcService.WriteButton("DB89.DBX0.3");
        }
        private async Task SR1513()
        {
            await _plcService.WriteButton("DB89.DBX0.4");
        }
        private async Task SR1514()
        {
            await _plcService.WriteButton("DB89.DBX0.5");
        }
        private async Task SR1515()
        {
            await _plcService.WriteButton("DB89.DBX0.6");
        }
        private async Task SR1516()
        {
            await _plcService.WriteButton("DB89.DBX0.7");
        }
        private async Task SR1517()
        {
            await _plcService.WriteButton("DB90.DBX0.0");
        }
        private async Task SR1518()
        {
            await _plcService.WriteButton("DB90.DBX0.1");
        }

        private void Connect()
        {
            _plcService.Connect(IpAddress, 0, 1);
        }
        private void Disconnect()
        {
            _plcService.Disconnect();
        }

       

    }
}
