#### Phạm vi truy cập
<table>
  <tr>
    <th>public</th>
    <th>private</th>
    <th>protected</th>
  </tr>
  <tr>
    <td>Không hạn chế. Thành phần có thuộc tính này có thể được truy cập ở bất kì vị trí nào.</td>
    <td>Thành phần có thuộc tính này sẽ chỉ được truy cập từ bên trong lớp. Bên ngoài lớp hay trong lớp dẫn xuất sẽ không thể truy cập được.</td>
    <td>Mở rộng hơn private một chút. Thành phần có thuộc tính này sẽ có thể truy cập ở trong nội bộ lớp và trong lớp dẫn xuất
( lớp dẫn xuất sẽ được trình bày trong bài Tính Kế Thừa )</td>
  </tr>
</table>

#### Class
```
class MyClass {       // The class
  public:             // Access specifier
    int myNum;        // Attribute (int variable)
    string myString;  // Attribute (string variable)
};

int main() {
  MyClass myObj;  // Create an object of MyClass

  // Access attributes and set values
  myObj.myNum = 15; 
  myObj.myString = "Some text";

  // Print attribute values
  cout << myObj.myNum << "\n";
  cout << myObj.myString;
  return 0;
}
```

#### Method
```
class MyClass {        // The class
  public:              // Access specifier
    void myMethod();   // Method/function declaration
};

// Method/function definition outside the class
void MyClass::myMethod() {
  cout << "Hello World!";
}

int main() {
  MyClass myObj;     // Create an object of MyClass
  myObj.myMethod();  // Call the method
  return 0;
}
```

#### Constructor 
> Toán tử phạm vi ```::``` dùng cho các phương thức định nghĩa bên ngoài lớp (phương thức này thuộc lớp)
```
class Car {        // The class
  public:          // Access specifier
    string brand;  // Attribute
    string model;  // Attribute
    int year;      // Attribute
    Car(string x, string y, int z); // Constructor declaration
};

// Constructor definition outside the class
Car::Car(string x, string y, int z) {
  brand = x;
  model = y;
  year = z;
}

int main() {
  // Create Car objects and call the constructor with different values
  Car carObj1("BMW", "X5", 1999);
  Car carObj2("Ford", "Mustang", 1969);

  // Print values
  cout << carObj1.brand << " " << carObj1.model << " " << carObj1.year << "\n";
  cout << carObj2.brand << " " << carObj2.model << " " << carObj2.year << "\n";
  return 0;
}
```

#### Tính đóng gói (Encapsulation - getter setter)
>Ý nghĩa của Encapsulation là đảm bảo rằng dữ liệu "nhạy cảm" được ẩn khỏi người dùng. Để đạt được điều này, bạn phải khai báo các biến/thuộc tính của lớp là private(không thể truy cập từ bên ngoài lớp). Nếu bạn muốn người khác đọc hoặc sửa đổi giá trị của một thành viên riêng, bạn có thể cung cấp các phương thức get và set công khai 
```
#include <iostream>
using namespace std;

class Employee {
  private:
    // Private attribute
    int salary;

  public:
    // Setter
    void setSalary(int s) {
      salary = s;
    }
    // Getter
    int getSalary() {
      return salary;
    }
};

int main() {
  Employee myObj;
  myObj.setSalary(50000);
  cout << myObj.getSalary();
  return 0;
}
```

#### Tính kế thừa (Inheritance - extend)
> Trong C++, có thể kế thừa các thuộc tính và phương thức từ lớp này sang lớp khác. Chúng tôi nhóm "khái niệm thừa kế" thành hai loại:
>
>>lớp dẫn xuất (con) - lớp kế thừa từ lớp khác
>
>>lớp cơ sở (cha mẹ) - lớp được kế thừa từ

>Để kế thừa từ một lớp ta sử dụng :ký hiệu. Trong ví dụ dưới đây, Car lớp (con) kế thừa các thuộc tính và phương thức từ Vehicle lớp (cha):
```
// Base class
class Vehicle {
  public:
    string brand = "Ford";
    void honk() {
      cout << "Tuut, tuut! \n" ;
    }
};

// Derived class
class Car: public Vehicle {
  public:
    string model = "Mustang";
};

int main() {
  Car myCar;
  myCar.honk();
  cout << myCar.brand + " " + myCar.model;
  return 0;
}
```

#### Tính đa hình (Polymorphism)
>Ví dụ, hãy nghĩ về một lớp cơ sở được gọi là Animal có một phương thức được gọi là animalSound(). Các lớp Động vật có nguồn gốc có thể là Lợn, Mèo, Chó, Chim - Và chúng cũng có cách thực hiện âm thanh động vật riêng (tiếng lợn kêu, tiếng mèo kêu, v.v.):
```
// Base class
class Animal {
  public:
    void animalSound() {
      cout << "The animal makes a sound \n";
    }
};

// Derived class
class Pig : public Animal {
  public:
    void animalSound() {
      cout << "The pig says: wee wee \n";
    }
};

// Derived class
class Dog : public Animal {
  public:
    void animalSound() {
      cout << "The dog says: bow wow \n";
    }
};
```
#### Abstract class
> Được tạo nhằm mục đích kế thừa, các lớp chỉ được kế thừa một Abstract
```
using System;
namespace oop
{
    abstract class Animal
    {
        public abstract void Speak();

        public virtual void Eat(string something)
        {
            Console.WriteLine("Eat " + something);
        }
    }
    
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog speaks go go");
        }
    }
    
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat speaks meo meo");
        }
    }
}
```
>Có thể thấy là class Dog, Cat chỉ có thể extend một abstract class, ở trên chúng ta viết method Eat() với từ khóa virtual nên class Dog, Cat có thể override lại.

#### Interface
>Interface không phải là class. Nó chỉ chứa những method/properties trống không có thực thi. Interface giống như một khuôn mẫu, một khung để để các lớp implement và follow. Các lớp có thể implements nhiều interface. Tức nó là một contract, các class implement phải triển khai các method theo như interface đã định nghĩa.
```
namespace oop
{
    interface IAnimal
    {
        void Speak();
        void Eat();
        int X { get; set; }
    }
    interface Interface2
    {
        int Method1();
    }
    
    class Pig : IAnimal,Interface2
    {
        public void Eat()
        {
            Console.WriteLine("Lợn ăn cám...");
        }

        public void Speak()
        {
            Console.WriteLine("Lợn kêu ec ec...");
        }

        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Method1() { throw new NotImplementedException(); }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Pig p = new Pig();
            Bird b = new Bird();
            p.Speak();
            p.Eat();

            b.Speak();
            b.Eat();
        }
    }
}
```

#### Virtual 
> Virtual là hàm ảo, có thể bị ghi đè bởi hàm cùng tên, cùng tham số, cùng kiểu trả về ở lớp kế thừa
```
using System;
namespace oop
{
    abstract class Animal
    {
        public virtual void Eat(string something)
        {
            Console.WriteLine("Eat " + something);
        }
    }
    
    class Dog : Animal
    {
        public override void Eat(string something)
        {
            Console.WriteLine("Dog speaks go go");
        }
    }
}
```
