partial class Program
{
    public static void LoopControlExample()
    {
        #region break
        for (int i = 0; i < 10; i++)
        {
            if (i == 5) break;
            WriteLine(i);
        }
        #endregion

        WriteLine("-----------------------------");

        #region continue
        for (int i = 0; i < 10; i++)
        {
            if (i == 5 || i == 7) continue;
            WriteLine(i);
        }
        #endregion

        WriteLine("-----------------------------");

        #region return
        for (int i = 0; i < 10; i++)
        {
            if (i == 3) return;
            WriteLine(i);
        }
        #endregion

        #region bucle infinito
        //while (true)
        //{
        //    WriteLine("Esto siempre se ejecutará");
        //}
        //for (;;)
        //{
        //    WriteLine("Esto tambien siempre se ejecutará");
        //}
        #endregion
    }
} 