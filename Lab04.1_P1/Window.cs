using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._1_P1
{
    internal class Window
    {
        private int top, left;

        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public int Top { get => top; set => top = value; }
        public int Left { get => left; set => left = value; }

        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: {0}, {1}", Top, Left);
        }
    }


    class Button : Window
    {
        public Button(int top, int left) : base(top, left)
        {
        }

        // Ghi đè phương thức 
        public override void DrawWindow()
        {
            Console.WriteLine("Window: {0}, {1}", Top, Left);
        }
    }
    class ListBox : Window
    {
        private string content;

  

        public ListBox(int top, int left, string content) : base(top, left)
        {
            this.content = content;
        }

        // Ghi đè phương thức 
        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Content: {0}", content);
            Console.WriteLine("Window: {0}, {1}", Top, Left);
        }

    }


}
