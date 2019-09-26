// Given a string with the weights of FFC members in normal order can you give this string ordered by "weights" of these numbers?
using System;
using System.Linq;

public class WeightSort {
	
	public static string orderWeight(string strng) {
    string result  =  String.Join(" " , strng
                            .Split(' ')
                            .OrderBy(item => item.Sum(x=>x - '0'))
                            .ThenBy(item => item));
    return result;
	}
}