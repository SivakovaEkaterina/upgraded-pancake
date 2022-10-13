namespace Пианино_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            while (c != 1)
            {
                Console.Clear();
                Console.WriteLine("Пианино. \n В игре есть 7 октав, переключение с помощью клавишь F1 - F7. Что бы выйти из игры нажните Enter. \n Ноты:\n Ц У   Е Н Г \nФ Ы В А П Р О");
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("Первая октава");
                    Fodin();
                }
                if (a.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("Вторая октава");
                    Fdwa();
                }
                if (a.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("Третья октава");
                    Ftri();
                }
                if (a.Key == ConsoleKey.F4)
                {
                    Console.WriteLine("Четвёртая октава");
                    Fchetire();
                }
                if (a.Key == ConsoleKey.F5)
                {
                    Console.WriteLine("Пятая октава");
                    Fpat();
                }
                if (a.Key == ConsoleKey.F6)
                {
                    Console.WriteLine("Шестая октава");
                    Fshest();
                }
                if (a.Key == ConsoleKey.F7)
                {
                    Console.WriteLine("Седьмая октава");
                    Fsem();
                }
                if (a.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("До свидания");
                    c = 1;
                }

            }


        }
        static void Fodin()
        {
            int[] Fodin = new int[] { 37, 37, 37, 37, 37, 37, 38, 41, 46, 43, 51, 49 };
            int b = 0;
            while (b != 1)
            {
                Console.Clear();
                Console.WriteLine("Первая октава. Нажмите любую F_ что бы выбрать октаву");
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.A)
                {
                    int nota = Fodin[0];
                    Console.Beep(nota, 750);
                    Console.WriteLine("До");
                }
                if (a.Key == ConsoleKey.W)
                {
                    int nota = Fodin[1];
                    Console.Beep(nota, 750);
                    Console.WriteLine("До#");
                }
                if (a.Key == ConsoleKey.S)
                {
                    int nota = Fodin[2];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ре");
                }
                if (a.Key == ConsoleKey.E)
                {
                    int nota = Fodin[3];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ре#");
                }
                if (a.Key == ConsoleKey.D)
                {
                    int nota = Fodin[4];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ми");
                }
                if (a.Key == ConsoleKey.F)
                {
                    int nota = Fodin[5];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Фа");
                }
                if (a.Key == ConsoleKey.T)
                {
                    int nota = Fodin[6];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Фа#");
                }
                if (a.Key == ConsoleKey.G)
                {
                    int nota = Fodin[7];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Соль");
                }
                if (a.Key == ConsoleKey.Y)
                {
                    int nota = Fodin[8];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Соль#");
                }
                if (a.Key == ConsoleKey.H)
                {
                    int nota = Fodin[9];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ля");
                }
                if (a.Key == ConsoleKey.U)
                {
                    int nota = Fodin[10];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ля#");
                }
                if (a.Key == ConsoleKey.J)
                {
                    int nota = Fodin[11];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Си");
                }
                if (a.Key == ConsoleKey.F1 || a.Key == ConsoleKey.F2 || a.Key == ConsoleKey.F3 || a.Key == ConsoleKey.F4 || a.Key == ConsoleKey.F5 || a.Key == ConsoleKey.F6 || a.Key == ConsoleKey.F7 || a.Key == ConsoleKey.F8)
                {
                    b = 1;
                }
                Console.Clear();
            }
        }
        static void Fdwa()
        {
            int[] Fdwa = new int[] { 55, 58, 61, 69, 65, 73, 77, 82, 92, 87, 103, 98 };
            int b = 0;
            while (b != 1)
            {
                Console.Clear();
                Console.WriteLine("Вторая октава. Нажмите любую F_ что бы выбрать октаву");
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.A)
                {
                    int nota = Fdwa[0];
                    Console.Beep(nota, 750);
                    Console.WriteLine("До");
                }
                if (a.Key == ConsoleKey.W)
                {
                    int nota = Fdwa[1];
                    Console.Beep(nota, 750);
                    Console.WriteLine("До#");
                }
                if (a.Key == ConsoleKey.S)
                {
                    int nota = Fdwa[2];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ре");
                }
                if (a.Key == ConsoleKey.E)
                {
                    int nota = Fdwa[3];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ре#");
                }
                if (a.Key == ConsoleKey.D)
                {
                    int nota = Fdwa[4];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ми");
                }
                if (a.Key == ConsoleKey.F)
                {
                    int nota = Fdwa[5];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Фа");
                }
                if (a.Key == ConsoleKey.T)
                {
                    int nota = Fdwa[6];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Фа#"); ;
                }
                if (a.Key == ConsoleKey.G)
                {
                    int nota = Fdwa[7];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Соль");
                }
                if (a.Key == ConsoleKey.Y)
                {
                    int nota = Fdwa[8];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Соль#");
                }
                if (a.Key == ConsoleKey.H)
                {
                    int nota = Fdwa[9];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ля");
                }
                if (a.Key == ConsoleKey.U)
                {
                    int nota = Fdwa[10];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ля#");
                }
                if (a.Key == ConsoleKey.J)
                {
                    int nota = Fdwa[11];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Си");
                }
                if (a.Key == ConsoleKey.F1 || a.Key == ConsoleKey.F2 || a.Key == ConsoleKey.F3 || a.Key == ConsoleKey.F4 || a.Key == ConsoleKey.F5 || a.Key == ConsoleKey.F6 || a.Key == ConsoleKey.F7 || a.Key == ConsoleKey.F8)
                {
                    b = 1;
                }
            }
        }
        static void Ftri()
        {
            int[] Ftri = new int[] { 110, 116, 123, 138, 130, 146, 155, 164, 185, 174, 207, 196 };
            int b = 0;
            while (b != 1)
            {
                Console.Clear();
                Console.WriteLine("Третья октава. Нажмите любую F_ что бы выбрать октаву");
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.A)
                {
                    int nota = Ftri[0];
                    Console.Beep(nota, 750);
                    Console.WriteLine("До");
                }
                if (a.Key == ConsoleKey.W)
                {
                    int nota = Ftri[1];
                    Console.Beep(nota, 750);
                    Console.WriteLine("До#");
                }
                if (a.Key == ConsoleKey.S)
                {
                    int nota = Ftri[2];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ре");
                }
                if (a.Key == ConsoleKey.E)
                {
                    int nota = Ftri[3];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ре#");
                }
                if (a.Key == ConsoleKey.D)
                {
                    int nota = Ftri[4];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ми");
                }
                if (a.Key == ConsoleKey.F)
                {
                    int nota = Ftri[5];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Фа");
                }
                if (a.Key == ConsoleKey.T)
                {
                    int nota = Ftri[6];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Фа#");
                }
                if (a.Key == ConsoleKey.G)
                {
                    int nota = Ftri[7];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Соль");
                }
                if (a.Key == ConsoleKey.Y)
                {
                    int nota = Ftri[8];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Соль#");
                }
                if (a.Key == ConsoleKey.H)
                {
                    int nota = Ftri[9];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ля");
                }
                if (a.Key == ConsoleKey.U)
                {
                    int nota = Ftri[10];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ля#");
                }
                if (a.Key == ConsoleKey.J)
                {
                    int nota = Ftri[11];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Си");
                }
                if (a.Key == ConsoleKey.F1 || a.Key == ConsoleKey.F2 || a.Key == ConsoleKey.F3 || a.Key == ConsoleKey.F4 || a.Key == ConsoleKey.F5 || a.Key == ConsoleKey.F6 || a.Key == ConsoleKey.F7 || a.Key == ConsoleKey.F8)
                {
                    b = 1;
                }

            }

        }
        static void Fchetire()
        {
            int[] Fchet = new int[] { 220, 233, 246, 277, 261, 293, 311, 329, 370, 349, 415, 392 };
            int b = 0;
            while (b != 1)
            {
                Console.Clear();
                Console.WriteLine("Четвёртая октава. Нажмите любую F_ что бы выбрать октаву");
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.A)
                {
                    int nota = Fchet[0];
                    Console.Beep(nota, 750);
                    Console.WriteLine("До");
                }
                if (a.Key == ConsoleKey.W)
                {
                    int nota = Fchet[1];
                    Console.Beep(nota, 750);
                    Console.WriteLine("До#");
                }
                if (a.Key == ConsoleKey.S)
                {
                    int nota = Fchet[2];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ре");
                }
                if (a.Key == ConsoleKey.E)
                {
                    int nota = Fchet[3];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ре#");
                }
                if (a.Key == ConsoleKey.D)
                {
                    int nota = Fchet[4];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ми");
                }
                if (a.Key == ConsoleKey.F)
                {
                    int nota = Fchet[5];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Фа");
                }
                if (a.Key == ConsoleKey.T)
                {
                    int nota = Fchet[6];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Фа#");
                }
                if (a.Key == ConsoleKey.G)
                {
                    int nota = Fchet[7];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Соль");
                }
                if (a.Key == ConsoleKey.Y)
                {
                    int nota = Fchet[8];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Соль#");
                }
                if (a.Key == ConsoleKey.H)
                {
                    int nota = Fchet[9];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ля");
                }
                if (a.Key == ConsoleKey.U)
                {
                    int nota = Fchet[10];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ля#");
                }
                if (a.Key == ConsoleKey.J)
                {
                    int nota = Fchet[11];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Си");
                }
                if (a.Key == ConsoleKey.F1 || a.Key == ConsoleKey.F2 || a.Key == ConsoleKey.F3 || a.Key == ConsoleKey.F4 || a.Key == ConsoleKey.F5 || a.Key == ConsoleKey.F6 || a.Key == ConsoleKey.F7 || a.Key == ConsoleKey.F8)
                {
                    b = 1;
                }
                
            }
        }
        static void Fpat()
        {
            int[] Fpat = new int[] { 440, 466, 493, 554, 523, 587, 622, 659, 740, 698, 830, 784 };
            int b = 0;
            while (b != 1)
            {
                Console.Clear();
                Console.WriteLine("Пятая октава. Нажмите любую F_ что бы выбрать октаву");
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.A)
                {
                    int nota = Fpat[0];
                    Console.Beep(nota, 750);
                    Console.WriteLine("До");
                }
                if (a.Key == ConsoleKey.W)
                {
                    int nota = Fpat[1];
                    Console.Beep(nota, 750);
                    Console.WriteLine("До#");
                }
                if (a.Key == ConsoleKey.S)
                {
                    int nota = Fpat[2];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ре");
                }
                if (a.Key == ConsoleKey.E)
                {
                    int nota = Fpat[3];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ре#");
                }
                if (a.Key == ConsoleKey.D)
                {
                    int nota = Fpat[4];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ми");
                }
                if (a.Key == ConsoleKey.F)
                {
                    int nota = Fpat[5];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Фа");
                }
                if (a.Key == ConsoleKey.T)
                {
                    int nota = Fpat[6];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Фа#");
                }
                if (a.Key == ConsoleKey.G)
                {
                    int nota = Fpat[7];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Соль");
                }
                if (a.Key == ConsoleKey.Y)
                {
                    int nota = Fpat[8];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Соль#");
                }
                if (a.Key == ConsoleKey.H)
                {
                    int nota = Fpat[9];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ля");
                }
                if (a.Key == ConsoleKey.U)
                {
                    int nota = Fpat[10];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ля#");
                }
                if (a.Key == ConsoleKey.J)
                {
                    int nota = Fpat[11];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Си");
                }
                if (a.Key == ConsoleKey.F1 || a.Key == ConsoleKey.F2 || a.Key == ConsoleKey.F3 || a.Key == ConsoleKey.F4 || a.Key == ConsoleKey.F5 || a.Key == ConsoleKey.F6 || a.Key == ConsoleKey.F7 || a.Key == ConsoleKey.F8)
                {
                    b = 1;
                }
                
            }
        }
        static void Fshest()
        {
            int[] Fshest = new int[] { 880, 932, 987, 1109, 1047, 1175, 1245, 1319, 1480, 1397, 1661, 1568 };
            int b = 0;
            while (b != 1)
            {
                Console.Clear();
                Console.WriteLine("Шестая октава.  Нажмите любую F_ что бы выбрать октаву");
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.A)
                {
                    int nota = Fshest[0];
                    Console.Beep(nota, 750);
                    Console.WriteLine("До");
                }
                if (a.Key == ConsoleKey.W)
                {
                    int nota = Fshest[1];
                    Console.Beep(nota, 750);
                    Console.WriteLine("До#");
                }
                if (a.Key == ConsoleKey.S)
                {
                    int nota = Fshest[2];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ре");
                }
                if (a.Key == ConsoleKey.E)
                {
                    int nota = Fshest[3];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ре#");
                }
                if (a.Key == ConsoleKey.D)
                {
                    int nota = Fshest[4];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ми");
                }
                if (a.Key == ConsoleKey.F)
                {
                    int nota = Fshest[5];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Фа");
                }
                if (a.Key == ConsoleKey.T)
                {
                    int nota = Fshest[6];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Фа#");
                }
                if (a.Key == ConsoleKey.G)
                {
                    int nota = Fshest[7];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Соль");
                }
                if (a.Key == ConsoleKey.Y)
                {
                    int nota = Fshest[8];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Соль#");
                }
                if (a.Key == ConsoleKey.H)
                {
                    int nota = Fshest[9];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ля");
                }
                if (a.Key == ConsoleKey.U)
                {
                    int nota = Fshest[10];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ля#");
                }
                if (a.Key == ConsoleKey.J)
                {
                    int nota = Fshest[11];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Си");
                }
                if (a.Key == ConsoleKey.F1 || a.Key == ConsoleKey.F2 || a.Key == ConsoleKey.F3 || a.Key == ConsoleKey.F4 || a.Key == ConsoleKey.F5 || a.Key == ConsoleKey.F6 || a.Key == ConsoleKey.F7 || a.Key == ConsoleKey.F8)
                {
                    b = 1;
                }
             
            }
        }
        static void Fsem()
        {
            int[] Fsem = new int[] { 1760, 1865, 1976, 2217, 2093, 2349, 2489, 2637, 2960, 2794, 3322, 3136 };
            int b = 0;
            while (b != 1)
            {
                Console.Clear();
                Console.WriteLine("Седьмая октава. Нажмите любую F_ что бы выбрать октаву");
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.A)
                {
                    int nota = Fsem[0];
                    Console.Beep(nota, 750);
                    Console.WriteLine("До");
                }
                if (a.Key == ConsoleKey.W)
                {
                    int nota = Fsem[1];
                    Console.Beep(nota, 750);
                    Console.WriteLine("До#");
                }
                if (a.Key == ConsoleKey.S)
                {
                    int nota = Fsem[2];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ре");
                }
                if (a.Key == ConsoleKey.E)
                {
                    int nota = Fsem[3];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ре#");
                }
                if (a.Key == ConsoleKey.D)
                {
                    int nota = Fsem[4];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ми");
                }
                if (a.Key == ConsoleKey.F)
                {
                    int nota = Fsem[5];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Фа");
                }
                if (a.Key == ConsoleKey.T)
                {
                    int nota = Fsem[6];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Фа#");
                }
                if (a.Key == ConsoleKey.G)
                {
                    int nota = Fsem[7];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Соль");
                }
                if (a.Key == ConsoleKey.Y)
                {
                    int nota = Fsem[8];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Соль#");
                }
                if (a.Key == ConsoleKey.H)
                {
                    int nota = Fsem[9];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ля");
                }
                if (a.Key == ConsoleKey.U)
                {
                    int nota = Fsem[10];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Ля#");
                }
                if (a.Key == ConsoleKey.J)
                {
                    int nota = Fsem[11];
                    Console.Beep(nota, 750);
                    Console.WriteLine("Си");
                }
                if (a.Key == ConsoleKey.F1 || a.Key == ConsoleKey.F2 || a.Key == ConsoleKey.F3 || a.Key == ConsoleKey.F4 || a.Key == ConsoleKey.F5 || a.Key == ConsoleKey.F6 || a.Key == ConsoleKey.F7 || a.Key == ConsoleKey.F8)
                {
                    b = 1;
                }
               
            }
        }
    }
}
/*int doo = Fodin[0];
int dooup = Fodin[1];
int re = Fodin[2];
int reup = Fodin[3];
int mi = Fodin[4];
int fa = Fodin[5];
int faup = Fodin[6];
int sol = Fodin[7];
int solup = Fodin[8];
int la = Fodin[9];
int laup = Fodin[10];
int si = Fodin[11];
return notipe[];*/

/*int[] Fodin = new int[] { 0, 0, 0, 17, 16, 18, 19, 20, 23, 21, 25, 24 };
int[] Fdva = new int[] { 27, 29, 30, 34, 32, 36, 38, 41, 46, 43, 51, 49 };
int[] Ftri = new int[] { 55, 58, 61, 69, 65, 73, 77, 82, 92, 87, 103, 98 };
int[] Fchetire = new int[] { 110, 116, 123, 138, 130, 146, 155, 164, 185, 174, 207, 196 };
int[] Fpat = new int[] { 220, 233, 246, 277, 261, 293, 311, 329, 370, 349, 415, 392 };
int[] Fshest = new int[] { 440, 466, 493, 554, 523, 587, 622, 659, 740, 698, 830, 784 };
int[] Fsem = new int[] { 880, 932, 987, 1109, 1047, 1175, 1245, 1319, 1480, 1397, 1661, 1568 };
int[] Fvosem = new int[] { 1760, 1865, 1976, 2217, 2093, 2349, 2489, 2637, 2960, 2794, 3322, 3136 };
int[] Fdevat = new int[] { 3520, 3729, 3951, 4435, 4186, 4699, 4978, 5274, 5920, 5588, 6645, 6272 };*/