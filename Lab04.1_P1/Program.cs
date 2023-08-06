using Lab04._1_P1;

internal class Program
{
    private static void Main(string[] args)
    {
        Window window = new Window(1,2);
        ListBox lstBox = new ListBox(3, 4, "aa");
        Button btn = new Button(2, 3);


        window.DrawWindow();
        lstBox.DrawWindow();
        btn.DrawWindow();

        Window[] arrWin = new Window[3];
        arrWin[0] = new Window(1, 2);
        arrWin[1] = new ListBox(3,4,"bbb");
        arrWin[2] = new Button(10, 20);

        for(int i=0; i< 3; i++)
        {
            arrWin[i].DrawWindow();
        }

    }
}