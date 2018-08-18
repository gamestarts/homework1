switch (choice)
{
case 0:return;
case 1:guide(); break;
case 2:
{
	system("cls");
	char go_on = 'y';
	string equation;
	while (go_on == 'y')
	{
		cout << endl << endl << "请输入算式，以=（等号）结束：" << endl;
		cin >> equation;
		calculate(equation);
		cout << "继续使用吗？是请输入y 否则输入n：";
		cin >> go_on;//可以循环进行算式计算
	}
	system("cls");
	menu();
}
case 3:
	readTxt("d:\\a.txt");
	menu();
}