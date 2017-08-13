namespace _02.Graphic_Editor
{
    public class Program
    {
        public static void Main()
        {
            IShape rectangle = new Rectangle();
            GraphicEditor editor = new GraphicEditor();

            editor.DrawShape(rectangle);
        }
    }
}
