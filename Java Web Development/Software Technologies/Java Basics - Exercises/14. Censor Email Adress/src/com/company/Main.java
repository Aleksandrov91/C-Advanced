package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String pattern = scan.nextLine();
        String text = scan.nextLine();

        String[] email = pattern.split("@");
        String userName = email[0];
        String domain = email[1];
        userName.replaceAll("//*", userName);
        String cryptedUseName = new String(new char[userName.length()]).replace('\0', '*') + "@" + domain;

        String replaced = text.replaceAll(pattern, cryptedUseName);

        System.out.print(replaced);
    }
}
