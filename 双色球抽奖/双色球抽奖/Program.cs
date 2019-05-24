using System;

namespace 双色球抽奖
{
    class Program
    {
        static void Main(string[] args)
        {    //公共变量
            //记录金额
            int money = 1;
            bool isLoop = true;
            int count = 0;
            int[,] array = new int[10, 7];//记录号码
            Console.WriteLine("抽奖难，难于上晴天。欢迎来到不会中奖的抽奖系统！！");
            while (isLoop)
            {
                Console.WriteLine("请选择：0 充值 1 自选 2 机选 3打印号码 4 开奖 5 退出");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        Console.WriteLine("输入充值金额：");
                        int jin = int.Parse(Console.ReadLine());
                        money += jin;
                        Console.WriteLine("充值{0}元成功！", jin);
                        Console.WriteLine("当前金额为{0}元", money);

                        break;
                    case 1:
                        if (money < 2)
                        {
                            Console.WriteLine("余额不足，请充值！");
                            break;
                        }
                        if (count == 10)
                        {
                            Console.WriteLine("购买组数达到上限");
                            break;
                        }
                        //定义数组
                        int[] item = new int[7];
                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine("请输入第{0}个红球号码：", 6 - i);
                            int red = Convert.ToInt32(Console.ReadLine());
                            item[i] = red;
                        }
                        Console.WriteLine("请输入蓝球号码：");
                        int bule = Convert.ToInt32(Console.ReadLine());
                        item[6] = bule;
                        for (int i = 0; i < 7; i++)
                        {
                            array[count, i] = item[i];
                        }
                        count++;
                        Console.WriteLine("您已经购买了{0}注", count);
                        Console.WriteLine("您购买的号码为");
                        for (int i = 0; i < 7; i++)
                        {
                            Console.Write(item[i] + " ");
                        }
                        Console.WriteLine();
                        money -= 2;

                        break;
                    case 2:
                        if (money < 2)
                        {
                            Console.WriteLine("余额不足，请充值！");
                            break;
                        }
                        if (count == 10)
                        {
                            Console.WriteLine("购买组数达到上限");
                            break;
                        }
                        int[] jixuan = new int[7];
                        Random rd = new Random();
                        int[] number = new int[33];
                        for (int i = 0; i < 33; i++)
                        {
                            number[i] = i + 1;
                        }
                        // 打乱数组
                        for (int i = 0; i < 33; i++)
                        {
                            int j = rd.Next(33);
                            int temp = number[i];
                            number[i] = number[j];
                            number[j] = temp;
                        }
                        //红球号码
                        for (int i = 0; i < 6; i++)
                        {
                            jixuan[i] = number[i];
                        }
                        //篮球号码
                        jixuan[6] = rd.Next(1, 17);
                        for (int i = 0; i < 7; i++)
                        {
                            array[count, i] = jixuan [i];
                        }
                        count++;
                        Console.WriteLine("您已经购买了{0}注", count);
                        Console.WriteLine("您购买的号码为");
                        for (int i = 0; i < 7; i++)
                        {
                            Console.Write(jixuan[i] + " ");
                        }
                        Console.WriteLine();
                        //扣费
                        money -= 2;

                        break;
                    case 3:
                        
                        for (int i = 0; i < count; i++)
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                Console.Write(array[i, j] + "\t ");
                            }
                            Console.WriteLine(" ");
                        }
                        Console.WriteLine("");
                        break;
                    case 4:
                        //确定中奖号码
                        int[] kaijiang = new int[7];
                        Random r = new Random();
                        int[] num = new int[33];
                        for (int i = 0; i < 33; i++)
                        {
                            num[i] = i + 1;
                        }
                        // 打乱数组
                        for (int i = 0; i < 33; i++)
                        {
                            int j = r.Next(33);
                            int temp = num[i];
                            num[i] = num[j];
                            num[j] = temp;
                        }
                        //中奖红球号码
                        for (int i = 0; i < 6; i++)
                        {
                            kaijiang[i] = num[i];
                        }
                       // 中奖蓝球号码
                        kaijiang[6] = r.Next(1, 17);
                        Console.WriteLine("打印中奖号码：");
                        for (int i = 0; i < 7; i++)
                        {
                            Console.Write(kaijiang[i] + " ");
                        }
                        Console.WriteLine(" ");
                        //  判断中奖
                        for (int i = 0; i < count; i++)
                        {
                            int Rcount = 0, Bcount = 0;
                            for (int j = 0; j < 6; j++)
                            {
                                Console.Write(array[i, j]+" ");
                                for (int k = 0; k < 6; k++)
                                {
                                    if (array[i, j] == kaijiang[k])
                                    {
                                        Rcount++;//中奖红球数
                                    }
                                }
                            }
                            Console.Write(array[i, 6]);
                            if (array[i, 6] == kaijiang[6])
                            {
                                Bcount++;
                            }
                            Console.WriteLine("中奖红球数{0}个，中奖蓝球数{1}", Rcount, Bcount);
                            //判断几等奖
                            if (Rcount == 6 && Bcount == 1)
                            {
                                Console.WriteLine("一等奖！！！");
                            }
                            else if (Rcount == 6 && Bcount == 0)
                            {
                                Console.WriteLine("二等奖！！");
                            }
                            else if (Rcount == 5 && Bcount == 1)
                            {
                                Console.WriteLine("三等奖");
                            }
                            else if (Rcount + Bcount == 5)
                            {
                                Console.WriteLine("四等奖");
                            }
                            else if (Rcount + Bcount == 4)
                            {
                                Console.WriteLine("五等奖");
                            }
                            else if (Rcount + Bcount == 0)
                            {
                                Console.WriteLine("没中奖");
                            }
                            else
                            {
                                Console.WriteLine("六等奖");
                            }

                        }
                        
                        //清空购买号码
                        array = new int[10, 7];
                        count = 0;
                        break;
                    case 5:
                        isLoop = false;
                        break;
                    default:
                        break;


                }
            }
        }
    }
}
