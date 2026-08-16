namespace Assigment_Session_4OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Q01
            //QA
            //Q:  What is Abstraction in Object-Oriented Programming? 
            /*Ans:
             * is the process of hiding the implementation details 
             * and showing only the essential features of an object to the user
            */

            //QB
            //Q:  Why is abstraction considered one of the four pillars of OOP? 
            /*Ans:
             * Becaus with abstraction 
                 * 1-Reduces complexity
                 * 2-Improves maintainability
                 * 3-Enhances security (hides sensitive details)
                 * 4-Promotes flexibility and reusability
             */
            #endregion

            #region Q02
            //QA
            //Q: What is the difference between an Abstract Class and an Interface? 

            /*Ans:
             
             * 1- Keyword =>   abstract  ||   interfacе
              
             * 2- Methods: 
             * Can have abstract and concrete methods 
             * (Before C# 8.0) Only abstract methods (From C# 8.0) Can have default and static methods
             
             * 3- Fields => Can have fields   ||  Cannot have fields (only constants)
             
             * 4- Access Modifiers => Can use any access modifier  ||  Members are public by default
             
             * 5- Inheritance => A class can inherit one abstract class ||  A class can implement multiple interfaces
             
             * 6- Constructor => Can have constructors  || Cannot have constructors

             */
            //=============================================================================================

            //QB:
            //Q: When would you choose an Interface instead of an Abstract Class? 

            /*Ans:
             * I use an interface when a behavior should be optional rather than mandatory for all derived classes. 
             * Only the classes that need that behavior implement the interface,
             * while the other derived classes are not forced to implement it.
             */
            //=============================================================================================

            //QC q1:
            //Q: Can a class inherit from multiple abstract classes? 

            /*Ans:
             *Multiple classes is not support in C# then answer -> cannot
             */

            //QC q2:
            //Q: Can it implement multiple interfaces?  

            /*Ans:
             *Yes can
             */

            #endregion



            #endregion
        }
    }
}
