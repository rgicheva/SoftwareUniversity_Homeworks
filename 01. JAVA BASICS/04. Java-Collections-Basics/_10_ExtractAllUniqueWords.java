package Lection4;

import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

public class _10_ExtractAllUniqueWords {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String text = sc.nextLine().toLowerCase();
		String[] words = text.split("\\W+");
		Set<String> uniqueWords = new TreeSet<String>();
		for (String word : words) {
			uniqueWords.add(word);
		}
		for (String word : uniqueWords) {
			System.out.print(word + " ");
		}
		sc.close();
	}
}