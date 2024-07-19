
using InheritanceDemo;

class Test
{
    static void Main(string[] args)
    {
        Parent parent = new Parent(); //parent reference can hold Parent() Runtime Object
        parent.M1();
        //parent.M2(); //Parent can't access child 

        Child child = new Child(); //chid reference can hold Child() Runtime object
        child.M1();
        child.M2();

        Parent parent1 = new Child(); //parent1 reference can hold Child() Runtume Object
        parent1.M1();
        //parent1.M2();  //parent can't access child but can hold child during compile time but gives error during runtime
                                           



        //Child child1 = new Parent(); //child1 reference can't hold Parent() Runtime Object
        //child1.M1();                 // In this child cannot accomodate Parent as parent size is big
        //child1.M2;


    }
}
