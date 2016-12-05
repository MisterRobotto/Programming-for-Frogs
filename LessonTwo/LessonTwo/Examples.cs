using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTwo
{
    class Examples
    {
        /* Hi there! This is a comment. This will let you say whatever you want and the computer will ignore it.
         * it's useful if you want to explain what your code does, or want to leave yourself a note! */

        // This is a single line comment. Any line starting with a "//" will be commented.

        /* This is a multi-line comment.
         * They can run on multiple lines!
         * These start with "/*" and end with -> */

        /*
        You can also use multi-line comments like this!
        */

        // CREATING VARIABLES
        int a = 0;
        int b = 1;

        private void LessonTwoExamples()
        {
            /*
            DEMONSTRATING CONDITIONAL OPERATORS
            */
            if(a == b)
            {
                // a is 0 and b is 1, so this will be false
            }

            if(a <= b)
            {
                // a is less than b, so this will be true
            }
            else if(a != b)
            {
                // a is not equal to b, so this would be true
                // HOWEVER! Since the previous if statement will be true, the code will never check this condition
            }

            if(a != 0 || b != 0)
            {
                // a equals 0, so the first part is false, but b is not equal to 0, so the second part is true
                // since this is an OR statement, this will be true
            }

            if (a != 0 && b != 0)
            {
                // a equals 0, so the first part is false, but b is not equal to 0, so the second part is true
                // since this is an AND statement, this will be false
            }
        }
    }
}
