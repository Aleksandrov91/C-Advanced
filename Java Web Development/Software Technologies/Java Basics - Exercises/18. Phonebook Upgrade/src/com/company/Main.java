package com.company;

import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        Map<String, String> phonebook = new TreeMap<>();

        String input = scan.nextLine();

        while (!input.equals("END")){

            String[] lineArgs = input.split(" ");

            String function = lineArgs[0];


            if (function.equals("A")){
                String name = lineArgs[1];
                String number = lineArgs[2];

                phonebook.put(name, number);

            } else if(function.equals("S")){
                String name = lineArgs[1];

                if (!phonebook.containsKey(name)){
                    System.out.printf("Contact %s does not exist. %n", name);
                } else {
                    System.out.printf("%s -> %s %n", name, phonebook.get(name));
                }
            } else if(function.equals("ListAll")) {
                for (String kvp : phonebook.keySet()) {
                    System.out.printf("%s -> %s %n", kvp, phonebook.get(kvp));
                }
            }

            input = scan.nextLine();
        }
    }
}
