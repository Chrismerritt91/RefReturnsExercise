class Student {

    //public field
    public int grade = 2;

    //public method
    public void PrintGrade() {

        Console.WriteLine("Grade: " + grade);
    }

    //public method with ref return
    public ref int DoWork() {

        // return refeerence of grade field
        return ref grade;
    }

}


class Program {

    static void Main() {

        //creating object of student
        Student s = new Student();

        //Call print grade
        s.PrintGrade();

        //call do work method
        ref int g = ref s.DoWork();

        //update the value of ref return
        g = 5;

        //Call print grade after updating the value of ref return
        s.PrintGrade();

        System.Console.ReadKey();

    }

}