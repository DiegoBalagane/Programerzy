using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programerzy
{
    class QuestionContainer
    {
		public static int size = 5;
		public Question[] table1 = new Question[size];
		public Question[] table2 = new Question[size];
		public Question[] table3 = new Question[size];
		public Question[] table4 = new Question[size];
		public Question[] table5 = new Question[size];
		public Question[] table6 = new Question[size];
		public Question[] table7 = new Question[size];
		public Question[] table8 = new Question[size];
		public Question[] table9 = new Question[size];
		public Question[] table10 = new Question[size];
		public Question[] table11 = new Question[size];
		public Question[] table12 = new Question[size];
		public QuestionContainer()
		{
			Question a1 = new Question("Która z poniższych wartości jest prawidłowa dla zmiennej typu boolean?", "false", "“false”", "10", "“truth”");
			Question b1 = new Question("Która z podanych typu może przechować wartości z zakresu -32768 do 32767?", "short", "long int", "long int", "int");
			Question c1 = new Question("Jaki jest właściwy zapis “Hello world” w języku Java?", "System.out.println(“Hello World”);", "echo(“Hello World”);", "print(“Hello World”);", "Console.WriteLine(“Hello World”);");
			Question d1 = new Question("Który operator odpowiada za porównanie dwóch wartości?", "==", "<>", "><", "=");
			Question e1 = new Question("Od jakiego indeksu zaczyna się każda tablica?", "0", "-1", "1", "2");
			table1[0] = a1;
			table1[1] = b1;
			table1[2] = c1;
			table1[3] = d1;
			table1[4] = e1;

			Question a2 = new Question("Które z wymienionych typów zmiennych odpowiada za pole znakowe?", "char", "int", "string", "enum");
			Question b2 = new Question("Jak nazywa się kod, w którym każdy znak jest przedstawiany jako 7-bitowa liczba całkowita?", "ASCII", "ASSCI", "ASCCI", "ASCI");
			Question c2 = new Question("Która zmienna egzemplarza pozwala poznać rozmiar tablicy w Javie?", "length", "MAX_VALUE", "size", "AMOUNT");
			Question d2 = new Question("W jaki sposób można zakomentować jedną linijkę kodu w Javie?", "// treść komentarza", "/* treść komentarza", "# treść komentarza", "/# treść komentarza");
			Question e2 = new Question("W jakim zakresie mieści się typ int?", "−2 147 483 648 — +2 147 483 647", "-34 890 - +34 889", "0 - +32 767", "−32 768 - +32 767");
			table2[0] = a2;
			table2[1] = b2;
			table2[2] = c2;
			table2[3] = d2;
			table2[4] = e2;

			Question a3 = new Question("Który z wymienionych konstruktorów nie istnieje w językach programowania?", "Usuwający", "Kopiujący", "Domyślny", "Przenoszący");
			Question b3 = new Question("Jaki operator powoduje wywołanie konstruktora i utworzenie nowego obiektu w Javie?", "new", "+", "instanceof", "delete");
			Question c3 = new Question("Co to jest JavaScript?", "Skryptowy język programowania", "Framework do języka Java", "Program do tworzenia grafiki", "Rozwinięcie nazwy Java");
			Question d3 = new Question("Których nawiasów należy użyć, aby zadeklarować tablicę w Javie?", "[ ]", "< >", "{ }", "( )");
			Question e3 = new Question("Ile wynosi liczba 43 zapisana w systemie binarnym?", "0010 1011", "0011 1011", "0010 1111", "0010 1010");
			table3[0] = a3;
			table3[1] = b3;
			table3[2] = c3;
			table3[3] = d3;
			table3[4] = e3;

			Question a4 = new Question("Co się stanie po wykonaniu poniższego fragmentu kodu: cout<<”Hello World”<<endl", "Błąd kompilacji", "Wyświetli się treść", "Powstanie przejście do kolejnej linii", "Powstanie akapit");
			Question b4 = new Question("Która pętla wykona się przynajmniej raz?", "do while", "for", "foreach", "while");
			Question c4 = new Question("Za pomocą jakiej metody w Javie można sprawdzić długość stringa?", "length();", "len();", "getLenght();", "getSize();");
			Question d4 = new Question("Które słowo kluczowe tworzy klasę w Javie?", "class", "className", "Class", "class();");
			Question e4 = new Question("Ile wynosi liczba 0100 0011 zapisana w systemie dziesiętnym?", "67", "69", "68", "66");
			table4[0] = a4;
			table4[1] = b4;
			table4[2] = c4;
			table4[3] = d4;
			table4[4] = e4;

			Question a5 = new Question("Które z wymienionych pojęć nie jest podstawowym paradygmatem programowania obiektowego?", "Wirtualizacja", "Hermetyzacja", "Dziedziczenie", "Polimorfizm");
			Question b5 = new Question("Jak nazywamy pierwotny typ klasowy?", "Typ bazowy", "Typ początkowy", "Typ startowy", "Typ pierwszy");
			Question c5 = new Question("Która biblioteka służy do dodawania tablic dynamicznych?", "<vector>", "<stack>", "<map>", "<regex>");
			Question d5 = new Question("Który operator bitowy odpowiada za operację bitową sumy modulo 2 w C++?", "^", "|", "%", "~");
			Question e5 = new Question("Które z wyrażeń jest poprawne?", "template<typename C> class Napis", "Żadne z wymienionych", "template<int C> class Napis", "template<C> class Napis");
			table5[0] = a5;
			table5[1] = b5;
			table5[2] = c5;
			table5[3] = d5;
			table5[4] = e5;

			Question a12 = new Question("Cykl Eulera powstał poprzez rozwiązanie problemu mostów pewnego miasta. Którego miasta ten problem dotyczył?", "Królewiec", "Sankt Petersburg", "Konin", "Hamburg");
			Question b12 = new Question("Która z kolekcji zezwala na przechowywanie tylko i wyłącznie unikalnych elementów?", "set", "vector", "regex", "array");
			Question c12 = new Question("Która z podanych metod powie nam, która wartość, x czy y, jest większa?", "Math.max(x,y);", "Math.larger(x,y);", "Math.maxNum(x,y);", "Math.maximum(x,y);");
			Question d12 = new Question("Utworzono obiekty obj1 i obj2. Co się stanie po użyciu instrukcji “obj2 = obj1”?", "Będą traktowane jako ten sam obiekt", "obj2 przyjmie wartości obj1", "obj1 przyjmie wartości obj2", "żadna odpowiedź nie jest prawidłowa");
			Question e12 = new Question("Którego z wymienionych operatorów nie można przeciążyć jedynie za pomocą funkcji składowych klasy?", "+", "=", "[ ]", "( )");
			table12[0] = a12;
			table12[1] = b12;
			table12[2] = c12;
			table12[3] = d12;
			table12[4] = e12;

			Question a11 = new Question("Jakim innym wyrazem nazywa się klasy?", "szablon", "obiekt", "egzemplarz", "zmienna");
			Question b11 = new Question("Z ilu klas nadrzędnych może bezpośrednio dziedziczyć podklasa w Javie?", "Z jednej", "Z dwóch", "Z ośmiu", "Nie ma ograniczeń");
			Question c11 = new Question("Kto jest twórcą języka Java?", "James Gosling", "Yukihiro Matsumoto", "Linus Torvalds", "Gilad Bracha");
			Question d11 = new Question("Który operator odpowiada za konkatenację w Javie?", "+", "*", "&&", ".");
			Question e11 = new Question("Która z wymienionych nazw zmiennych jest niepoprawna?", "1value", "one", "one_and_two", "color1");
			table11[0] = a11;
			table11[1] = b11;
			table11[2] = c11;
			table11[3] = d11;
			table11[4] = e11;

			Question a10 = new Question("Jaki charakter może mieć aktywacja metody wirtualnej?", "Dynamiczny i statyczny", "Tylko dynamiczny", "Tylko statyczny", "Nie da się jej aktywować");
			Question b10 = new Question("Który rodzaj metod dotyczy wszystkich obiektów klasy, a nie konkretnego obiektu w języku Java?", "Metody klasy", "Metody uniwersalne", "Metody egzemplarza", "Funkcje uniwersalne");
			Question c10 = new Question("Który sposób utworzenia obiektu w Javie jest prawidłowy?", "MyClass myObj = new MyClass();", "MyClass myObj();", "new myObj = MyClass();", "class MyClass = new myObj();");
			Question d10 = new Question("Które słowo kluczowe dołącza pakiet z biblioteki Java API?", "import", "package", "extends", "getlib");
			Question e10 = new Question("Jaka jest wartość liczbowa wyrażenia zapisanego w odwrotnej notacji polskiej: 3 5 2 * + ?", "13", "15", "30", "18");
			table10[0] = a10;
			table10[1] = b10;
			table10[2] = c10;
			table10[3] = d10;
			table10[4] = e10;

			Question a9 = new Question("Który z wymienionych przeciążonych operatorów nie traci swoich specjalnych właściwości?", "Żaden z wymienionych", "&&&& (i)", "|| (lub)", ", (przecinek)");
			Question b9 = new Question("Które z poniższych sortowań nie jest stabilne?", "Quicksort", "Mergesort", "Bubblesort", "Shakersort");
			Question c9 = new Question("W jaki sposób stworzysz w Javie zmienną traktowaną jako float?", "float x = 2.8f;", "byte x = 2.8f;", "float x = 2.8;", "int x = 2.8f;");
			Question d9 = new Question("Kto jest twórcą języka C++?", "Bjarne Stroustrup", "Dennis Ritchie", "Alonzo Church", "Ken Thompson");
			Question e9 = new Question("Która z metod przeszukiwania drzewa binarnego zwróci posortowane rosnąco elementy?", "Inorder", "Postorder", "Preorder", "Wszystkie z wymienionych");
			table9[0] = a9;
			table9[1] = b9;
			table9[2] = c9;
			table9[3] = d9;
			table9[4] = e9;

			Question a8 = new Question("Za pomocą którego trybu dziedziczenia dostaniemy się do wszystkich atrybutów klasy bez użycia “getterów”?", "Public", "Protected", "Private", "Public i Protected");
			Question b8 = new Question("Które pakiety są automatycznie importowane do wszystkich klas Javy?", "Klasy z pakietu java.lang", "Żadne", "Klasa z pakietu java.basic", "Klasy z pakietu java.start");
			Question c8 = new Question("Która metoda zwraca stringa zbudowanego tylko z wielkich liter w Javie?", "toUpperCase();", "tuc();", "touppercase()", "upperCase();");
			Question d8 = new Question("Ile wynosi liczba 16B zapisana w systemie dziesiętnym?", "363", "312", "394", "364");
			Question e8 = new Question("Która z wymienionych sortowania ma złożoność obliczeniową O(n*n)?", "Bubblesort", "Quicksort", "Heapsort", "Mergesort");
			table8[0] = a8;
			table8[1] = b8;
			table8[2] = c8;
			table8[3] = d8;
			table8[4] = e8;

			Question a7 = new Question("Której z wymienionych instrukcji używa się do właściwej obsługi wyjątków?", "Catch", "Throw", "Try", "Wszystkie odpowiedzi są poprawne");
			Question b7 = new Question("Który z wymienionych typów danych jest obsługiwany przez klauzulę case?", "Znaki", "Teksty", "Obiekty", "Zmienne boolowskie");
			Question c7 = new Question("Jaki typ danych przechowuje zmienne łańcuchowe w Javie?", "String", "string", "text", "txt");
			Question d7 = new Question("W jaki sposób wywołuje się metody w Javie?", "methodName();", "(methodName);", "methodName;", "methodName[];");
			Question e7 = new Question("Jakiego typu jest metoda: basic_regex::empty()?", "bool", "string", "int", "char");
			table7[0] = a7;
			table7[1] = b7;
			table7[2] = c7;
			table7[3] = d7;
			table7[4] = e7;

			Question a6 = new Question("Ile destruktorów maksymalnie może liczyć klasa?", "Jeden", "Dwa", "Trzy", "Nieskończoną ilość");
			Question b6 = new Question("Co jest potrzebne do utworzenia klasy abstrakcyjnej?", "Czysta metoda wirtualna", "“abstract” przed deklaracją klasy", "Metoda wirtualna", "Żadne z wymienionych");
			Question c6 = new Question("Która z wymienionych bibliotek umożliwia wykorzystanie manipulatorów?", "<iomanip>", "<cstdlib>", "<iostream>", "<conio.h>");
			Question d6 = new Question("W jaki sposób tworzy się metody w Javie?", "methodName();", "methodName[];", "methodName;", "(methodName);");
			Question e6 = new Question("Którą z tych wartości może przyjąć zmienna typu char?", "s", "false", "3600U", "Żadną z wymienionych");
			table6[0] = a6;
			table6[1] = b6;
			table6[2] = c6;
			table6[3] = d6;
			table6[4] = e6;
		}
		public Question choiceOfQuestion(Question[] table)
		{
			Random xd = new Random();
			int index = xd.Next(0, 5);
			return table[index];
		}
		public Question getQuestion1()
		{
			return choiceOfQuestion(table1);
		}
		public Question getQuestion2()
		{
			return choiceOfQuestion(table2);
		}
		public Question getQuestion3()
		{
			return choiceOfQuestion(table3);
		}
		public Question getQuestion4()
		{
			return choiceOfQuestion(table4);
		}
		public Question getQuestion5()
		{
			return choiceOfQuestion(table5);
		}
		public Question getQuestion6()
		{
			return choiceOfQuestion(table6);
		}
		public Question getQuestion7()
		{
			return choiceOfQuestion(table7);
		}
		public Question getQuestion8()
		{
			return choiceOfQuestion(table8);
		}
		public Question getQuestion9()
		{
			return choiceOfQuestion(table9);
		}
		public Question getQuestion10()
		{
			return choiceOfQuestion(table10);
		}
		public Question getQuestion11()
		{
			return choiceOfQuestion(table11);
		}
		public Question getQuestion12()
		{
			return choiceOfQuestion(table12);
		}
	}
}
