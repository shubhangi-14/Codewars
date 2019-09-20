// Implement a method that accepts 3 integer values a, b, c. The method should return true if a triangle can be built with the sides of given length and false in any other case.

// (In this case, all triangles must have surface greater than 0 to be accepted).
public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        if((a+b)>c)
        {
          if((b+c)>a)
          {
            if((a+c)>b)
            {
                return true;
            }
          }
        }
        return false;
    }
}