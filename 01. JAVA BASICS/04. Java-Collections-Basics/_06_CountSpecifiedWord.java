package Lection4;

import java.util.Scanner;

public class _06_CountSpecifiedWord {

	public static void main(String[] args) {
		System.out.println("Please enter some text:");
		Scanner scan = new Scanner(System.in);
		String text = scan.nextLine();
		String targetWord = scan.nextLine();
		targetWord = targetWord.toLowerCase();
		String[] textArray = text.split("\\W+");
		int count = 0;
		for(int i = 0; i < textArray.length; i++) {
			String temp = textArray[i].toLowerCase();
			if(temp.equals(targetWord)) {
				count++;
			}
		}
		System.out.println(count);
		scan.close();
	}

}
