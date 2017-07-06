namespace Text_Gravity
{
    using System;
    using System.Security;
    using System.Text;

    public class TextGravity
    {
        public static void Main()
        {
            var cols = int.Parse(Console.ReadLine());
            var text = Console.ReadLine();
            int rows = (int)Math.Ceiling((decimal)text.Length / cols);
            
            var matrix = new char[rows][];
            var offset = 0;
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new char[cols];
                for (int j = 0; j < cols; j++)
                {
                    if (offset < text.Length)
                    {
                        matrix[i][j] = text[offset];
                        offset++;
                    }
                    else
                    {
                        matrix[i][j] = ' ';
                    }
                }
            }

            for (int i = 0; i < cols; i++)
            {
                for (int j = rows - 1; j >= 0; j--)
                {
                    if (matrix[j][i] == ' ')
                    {
                        for (int k = j-1; k >=0 ; k--)
                        {
                            if (matrix[k][i] != ' ')
                            {
                                matrix[j][i] = matrix[k][i];
                                matrix[k][i] = ' ';
                                break;
                            }
                        }
                    }
                }
            }

            var sb = new StringBuilder();
            sb.Append("<table>");

            for (int i = 0; i < rows; i++)
            {
                sb.Append("<tr>");
                for (int j = 0; j < cols; j++)
                {
                    sb.Append($"<td>{SecurityElement.Escape(matrix[i][j].ToString())}</td>");
                }
                sb.Append("</tr>");
            }
            sb.Append("</table>");

            Console.WriteLine(sb);
        }
    }
}
