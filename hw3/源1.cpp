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
		cout << endl << endl << "��������ʽ����=���Ⱥţ�������" << endl;
		cin >> equation;
		calculate(equation);
		cout << "����ʹ������������y ��������n��";
		cin >> go_on;//����ѭ��������ʽ����
	}
	system("cls");
	menu();
}
case 3:
	readTxt("d:\\a.txt");
	menu();
}