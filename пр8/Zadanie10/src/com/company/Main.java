package com.company;

public class Main {
    public static double getRandomNumber(double min, double max){
        double x = (int)(Math.random()*((max-min)+1))+min;
        return x;
    }
    public static void main(String[] args) {
        double [][] randomNumber =new double [10][10];
	    for(int i=0;i<10;i++){
	        for(int j=0;j<10;j++){
	            randomNumber[i][j]=getRandomNumber(0,10);
	            System.out.print((int)randomNumber[i][j]+"\t ");
             }
	    System.out.println();
        }
        int max =(int)randomNumber[0][0];
        int max_x=0;
        int max_y=0;
        int n =randomNumber.length;
        for(int i=0;i<randomNumber.length;i++){
                if(randomNumber[i][i]>max){
                    max = (int)randomNumber[i][i];
                    max_y=i;
                    max_x=i;
                }
            }
        System.out.print("Max: "+max+" X:"+max_x+" Y:"+max_y+"\n");
        max=0;
        for(int i=0;i<n;i++){
            if(randomNumber[i][n-i-1]>max){
                max = (int)randomNumber[i][n-i-1];
                max_y=i;
                max_x=n-i;
            }
        }
        System.out.print("Max: "+max+" X:"+max_x+" Y:"+max_y+"\n");
        int sum=0;
        for(int i=0;i<10;i++){
            for(int j=0;j<10;j++){
                sum=sum+(int)randomNumber[j][i];
            }
            System.out.println("Сумма "+i+" столбца: "+sum);
            sum=0;
        }
    }
}

