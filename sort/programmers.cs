using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study_DSA_cs.sort
{
    public class programmers
    {
        public static void _42746()
        {
            int[] numbers = new int[5];
            numbers[0] = 3;
            numbers[1] = 30;
            numbers[2] = 34;
            numbers[3] = 5;
            numbers[4] = 9;
            string answer = "";
            int max_length = 1000;
            StringBuilder string_builder = new StringBuilder();
            Dictionary<int, string> number_dic = new Dictionary<int, string>();

            for (int i = 0; i < numbers.Length; ++i)
            {
                string num_str = numbers[i].ToString();

                // 최대크기의 자릿수보다 클 때까지 반복하여 채움 (ex - 6->6666, 30->3030, 121->121121)
                while (num_str.Length < max_length)
                {
                    num_str = num_str + num_str;
                }

                // 최대크기 자릿수를 초과하면 앞의 자릿수만 추출
                if (num_str.Length > max_length)
                {
                    num_str = num_str.Substring(0, max_length);
                }

                number_dic.Add(i, num_str);
            }

            // 딕셔너리에 담긴 데이터를 정렬
            var result_dic = number_dic.OrderByDescending(x => x.Value);

            // 정렬된 딕셔너리 값을 모두 합침
            foreach (var key_value in result_dic)
            {
                string_builder.Append(numbers[key_value.Key]);
            }

            // [0,0,0,0,0] 과 같은 케이스의 예외처리
            if (string_builder[0] == '0')
            {
                string_builder.Clear();
                string_builder.Append("0");
            }
            answer = string_builder.ToString();
            Console.WriteLine(answer);
        }
    }
}
