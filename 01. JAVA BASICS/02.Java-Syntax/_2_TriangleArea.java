package Lection2;

import java.util.Scanner;


public class _2_TriangleArea {

	public static void main(String[] args) {
		System.out.println("Enter three points with x and y coordinates separated by space:");
		Scanner sc = new Scanner(System.in);
		String firstPoint = sc.nextLine();
		String firstArr[] = firstPoint.split(" ");
		int ax = Integer.parseInt(firstArr[0]);
		int ay = Integer.parseInt(firstArr[1]);
		String secondPoint = sc.nextLine();
		String secondArr[] = secondPoint.split(" ");
		int bx = Integer.parseInt(secondArr[0]);
		int by = Integer.parseInt(secondArr[1]);
		String thirdPoint = sc.nextLine();
		String thirdArr[] = thirdPoint.split(" ");
		int cx = Integer.parseInt(thirdArr[0]);
		int cy = Integer.parseInt(thirdArr[1]);
		int area = Math.abs(ax*(by-cy)+bx*(cy-ay)+cx*(ay-by))/2;
		if(area>=0) 
			System.out.println(area);
		else
			System.out.println(0);
		sc.close();
	}

}

