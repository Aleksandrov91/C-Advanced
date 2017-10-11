package com.company;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        Map<String, String> phonebook = new LinkedHashMap<String, String>();

        String input = scan.nextLine();

        while (!input.equals("END")){

            String[] lineArgs = input.split(" ");

            String function = lineArgs[0];
            String name = lineArgs[1];

            if (function.equals("A")){
                String number = lineArgs[2];

                phonebook.put(name, number);

            } else if(function.equals("S")){
                if (!phonebook.containsKey(name)){
                    System.out.printf("Contact %s does not exist. %n", name);
                } else {
                    System.out.printf("%s -> %s %n", name, phonebook.get(name));
                }
            }

            input = scan.nextLine();
        }
    }
}
