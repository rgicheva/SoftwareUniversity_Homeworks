package Lection2;

import java.util.Scanner;

public class _1_RectangleArea {
	public static void main(String[] args) {
	
		System.out.println("Enter sides a and b of a rectangle separated by space:");
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine();
		String arr[] = input.split(" ");
		int width = Integer.parseInt(arr[0]);
		int height = Integer.parseInt(arr[1]);
		System.out.println(width*height);
		sc.close();
	}
}