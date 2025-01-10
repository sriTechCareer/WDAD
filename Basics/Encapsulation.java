
class Employee {
    private int id;
    private String name;
    private double salary;

   
    public Employee(int id, String name, double salary) {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }

    public int getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    public double getSalary() {
        return salary;
    }

    public void setId(int id) {
        this.id = id;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setSalary(double salary) {
        this.salary = salary;
    }
} 
public class Encapsulation {
    public static void main(String[] args) {
        Employee emp = new Employee(101, "John", 5000.0);
        System.out.println("Employee ID: " + emp.getId());
        System.out.println("Employee Name: " + emp.getName());
        System.out.println("Employee Salary: " + emp.getSalary());
        emp.setId(102);
        emp.setName("Jane");
        emp.setSalary(6000.0);
        System.out.println("Updated Employee ID: " + emp.getId());
        System.out.println("Updated Employee Name: " + emp.getName());
        System.out.println("Updated Employee Salary: " + emp.getSalary());
    }
}
