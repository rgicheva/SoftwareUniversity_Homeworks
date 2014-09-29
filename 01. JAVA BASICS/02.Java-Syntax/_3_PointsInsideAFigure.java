package Lection2;

import java.util.Scanner;

public class _3_PointsInsideAFigure {

	public static void main(String[] args) {
		System.out.println("Please enter a point with x and y coordinates separetad by space");
		Scanner sc = new Scanner(System.in);
		String points = sc.nextLine();
		String pointsArr[] = points.split(" ");
		float x = Float.parseFloat(pointsArr[0]);
		float y = Float.parseFloat(pointsArr[1]);
        if((x>=12.5 && x<=22.5 && y>=6 && y <= 13.5) 
        		|| (x>=12.5 && x<=17.5 && y>=8.5 && y <= 13.5) 
        		|| (x >=20 && x<=22.5 && y>8.5 && y<=13.5)){
        	System.out.println("Inside");
        }
        else {
        	System.out.println("Outside");
        }
		sc.close();
		
	}

}
