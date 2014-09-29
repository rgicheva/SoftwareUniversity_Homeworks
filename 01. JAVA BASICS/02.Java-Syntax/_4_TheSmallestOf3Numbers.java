package Lection2;

import java.util.Scanner; 

public class _4_TheSmallestOf3Numbers {

	public static void main(String[] args) {
		System.out.println("Please enter three number separeted by space:");
		Scanner sc = new Scanner(System.in);
		String numbers = sc.nextLine();
		String numbersArr[] = numbers.split(" "); 
		double a = Double.parseDouble(numbersArr[0]);
		double b = Double.parseDouble(numbersArr[1]);
		double c = Double.parseDouble(numbersArr[2]);
		double smallest;
		if(a<b && a<c) {
			smallest=a;
		}else if(b<c && b<a){
			smallest = b;
		}else{
			smallest=c;
		}
		System.out.println(smallest);
		sc.close();
		
	}

}
