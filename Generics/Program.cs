﻿
using Generics;

//IntList datas = new IntList();

//datas.Add(1);
//datas.Add(2);
//datas.Add(3);
//datas.Add(4);
//datas.Add(5);

//int[] result = datas.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//StringList stringList = new StringList();

//stringList.Add("salam");
//stringList.Add("sagol");

//var result2 = stringList.GetAll();

//foreach (var item in result2)
//{
//    Console.WriteLine(item);
//}


//DataList<int> datas = new DataList<int>();

//datas.Add(100);
//datas.Add(200);
//datas.Add(300);

//var result = datas.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}



//DataList<string> dataList = new DataList<string>();

//dataList.Add("salam");
//dataList.Add("salam2");

//var result2 = dataList.GetAll();

//foreach (var item in result2)
//{
//    Console.WriteLine(item);
//}



//DataList<bool> dataList1 = new DataList<bool>();

//dataList1.Add(true);
//dataList1.Add(false);
//dataList1.Add(true);

//var result3 = dataList1.GetAll();

//foreach (var item in result3)
//{
//    Console.WriteLine(item);
//}



//DataList<Book> books = new DataList<Book>();
//books.Add(new Book { Id = 1, Name = "test1" });
//books.Add(new Book { Id = 2, Name = "test2" });
//books.Add(new Book { Id = 3, Name = "test3" });

//var result = books.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item.Name);
//}



DataList<int> dataList = new();

dataList.Add(0);
dataList.Add(3);
dataList.Add(1);
dataList.Add(2);
dataList.Add(3);

dataList.Delete(3);

var result = dataList.GetAll();

foreach (var item in result)
{
    Console.WriteLine(item);
}


