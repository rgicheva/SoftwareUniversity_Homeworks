package Lection4;

import java.util.Scanner;

public class _05_CountAllWords {

	public static void main(String[] args) {
		System.out.println("Please enter some text:");
		Scanner scan = new Scanner(System.in);
		String text = scan.nextLine();
		String[] textArray = text.split("\\W+");
		System.out.println(textArray.length);
		scan.close();
	}

}
