// Практическая работа №14. Часть 2. Мансуров В. ИСП-21
/* Описать процедуру AddRightDigit(D, K), добавляющую к целому 
	положительному числу K справа цифру D (D — входной параметр целого типа, лежащий 
	в диапазоне 0–9, K — параметр целого типа, являющийся одновременно входным и 
	выходным). С помощью этой процедуры последовательно добавить к данному числу K 
	справа данные цифры D1 и D2, выводя результат каждого добавления */

int inputValueD, inputValueK, inputValueD1, inputValueD2, resFunction;

int AllRightDigit(int D, int K)
{
    K += D;

	Console.WriteLine("Релузльтат K: {0}", K);
	return K;
}

Console.WriteLine("Введите D и K: ");
inputValueD = Convert.ToInt32(Console.ReadLine());
inputValueK = Convert.ToInt32(Console.ReadLine());
resFunction = AllRightDigit(inputValueD, inputValueK);

Console.WriteLine("Введите D1: ");
inputValueD1 = Convert.ToInt32(Console.ReadLine());

resFunction = AllRightDigit(inputValueD1, resFunction);

Console.WriteLine("Введите D2: ");
inputValueD2 = Convert.ToInt32(Console.ReadLine());

AllRightDigit(inputValueD2, resFunction);
