using System.Collections.Generic;

namespace TaskWithStar
{
    //Римская система счисления - непозиционная система счисления, в которой для записи чисел используются буквы латинского алфавита:
    //1 - I, 5 - V, 10 - X, 50 - L, 100 - C, 500 - D и 1000 - M.

    // Для правильной записи больших чисел римскими цифрами необходимо сначала записать число тысяч, затем сотен, затем десятков и, наконец, единиц.
    // Натуральные числа записываются при помощи повторения этих цифр.
    // При этом, если большая цифра стоит перед меньшей, то они добавляются (принцип сложения), если же меньшая – перед большей, то меньшая вычитается из большей (принцип вычитания).
    // Последнее правило применяется только во избежание четырехкратного повторения одной цифры.
    // Например, I, Х, С ставятся соответственно перед Х, С, М для обозначения 9, 90, 900 или перед V, L, D для обозначения 4, 40, 400.
    // Например, VI = 5 + 1 = 6, IV = 5 - 1 = 4(вместо IIII); XIX = 10 + 10 – 1 = 19 (вместо XVIIII), XL = 50 - 10 = 40 (вместо XXXX).


    /// <summary>
    /// Класс, преобразующий число из римской системы счисления в арабскую.
    /// </summary>
    public static class Converter
    {
        ///// <summary>
        ///// Римские цифры
        ///// </summary>
        //private static Dictionary<char, int> romanDigits = new Dictionary<char, int>
        //{
        //    { 'I', 1 },
        //    { 'V', 5 },
        //    { 'X', 10 },
        //    { 'L', 50 },
        //    { 'C', 100 },
        //    { 'D', 500 },
        //    { 'M', 1000 }
        //};

        /// <summary>
        /// Сконвертировать число из римской системы счисления в арабскую
        /// </summary>
        /// <param name="romanNumber">Число в римской системе счисления</param>
        /// <returns>Число в арабской системе счисления или текст ошибки</returns>
        public static string Convert(string romanNumber)
        {
            //var arabicDigits = new int[0];            
            var romanDigits = romanNumber.ToCharArray();
            var intermediateArabicDigits = new List<int>();
            int result = 0;
            string errorMessage = "";

            // I = 1; V = 5; X = 10; L = 50; C = 100; D = 500; M = 1000.
            foreach (char ch in romanDigits)
            {
                switch (ch)
                {
                    case 'I':
                        intermediateArabicDigits.Add(1);
                        break;

                    case 'V':
                        intermediateArabicDigits.Add(5);
                        break;

                    case 'X':
                        intermediateArabicDigits.Add(10);
                        break;

                    case 'L':
                        intermediateArabicDigits.Add(50);
                        break;

                    case 'C':
                        intermediateArabicDigits.Add(100);
                        break;

                    case 'D':
                        intermediateArabicDigits.Add(500);
                        break;

                    case 'M':
                        intermediateArabicDigits.Add(1000);
                        break;
                    default:
                        errorMessage = "Символ \"" + ch + "\" не используется в римской системе счисления.";
                        break;
                }
            }

            // Если встретились неиспользуемые символы
            if (errorMessage.Length > 0)
                return errorMessage;
            // Если римское число состояло из одной цифры, то и соответствующее ему арабское число тоже одно (из одной или нескольких цифр)
            if (intermediateArabicDigits.Count == 1)
            {
                result = intermediateArabicDigits[0];
            }
            // Если римское число состояло из двух и более цифр - применяем следующий алгоритм.
            else
            {   
                // Алгоритм:
                // Сравниваем каждое число со следующим, _начиная с правого края_ (т.е. XIX = X + IX = 19, а не XI + X = 21).
                // Если левое число меньше правого - вычитаем его из результата.
                // Если больше _или равно_ - складываем его с результатом.

                // Пример-тест алгоритма №1: XXXVIII - это 38.
                // результат = 1 (I, первая цифра справа)
                // I и I - равны, складываем его с результатом, получаем 2
                // I и I - равны, складываем его с результатом, получаем 3
                // V и I - левое больше правого, складываем его с результатом, получаем 8
                // X и V - левое больше правого, складываем его с результатом, получаем 18
                // X и X - равны, складываем его с результатом, получаем 28
                // X и X - равны, складываем его с результатом, получаем 38
                // результат = 38
                
                // Пример-тест алгоритма №2: XIX - это 19.
                // результат = 10 (X, первая цифра справа)                
                // I и X - левое меньше правого, вычитаем его из результата, получаем 9
                // X и I - левое больше правого, складываем его с результатом, получаем 19
                // результат = 19

                // Пример-тест алгоритма №3: XXI - это 21.
                // результат = 1 (I, первая цифра справа)
                // X и I - левое больше правого, складываем его с результатом, получаем 11
                // X и X - равны, складываем его с результатом, получаем 21
                // результат = 21

                // индексация коллекций начинается с нуля
                // при числе элементов 3 индекс последнего будет 2, (Count - 1)
                result = intermediateArabicDigits[intermediateArabicDigits.Count - 1];

                for (int i = intermediateArabicDigits.Count - 1; i > 0; i--)
                {
                    int leftNumber = intermediateArabicDigits[i - 1];
                    int rightNumber = intermediateArabicDigits[i];

                    if (leftNumber < rightNumber)
                    {
                         result = result - leftNumber;
                    }
                    else
                    {
                        result = result + leftNumber;
                    }
                }
            }

            return result.ToString();
        }
    }
}