// See https://aka.ms/new-console-template for more information
using mtapi.mt5;

Console.WriteLine("Hello, World!");
Connect();


void Connect()
{
	//var api = new MT5API(18574, "uaDZ3mjC6", "13.114.200.108", 443);
	//var api = new MT5API(99083840, "ychqluy5", "112.126.96.179", 443); //xdl demo
	//var api = new MT5API(40910506, "JWT81h4i50gA", "91.134.185.136", 1950); //admiral demo
	//var api = new MT5API(40910506, "JWT81h4i50gA", "91.134.185.136", 1950); //admiral demo
	//var api = new MT5API(22098451, "test1234", "mt5demo101.loginandtrade.com", 443);
	//var api = new MT5API(1000028, "aykJc3ta", "51.143.162.218", 443);
	var api = new MT5API(686870, "7anrdcpc", "136.244.68.219", 443);


	api.OnConnectProgress += Qc_OnConnectProgress;
	api.Connect();
	Console.WriteLine(api.GetOpenedOrders().Length + " " + api.AccountProfit);
	Console.WriteLine("Done");
	Console.ReadKey();
}

 void Qc_OnConnectProgress(MT5API sender, ConnectEventArgs args)
{
	Console.WriteLine(args.Progress);
}