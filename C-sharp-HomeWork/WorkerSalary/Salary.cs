namespace WorkerSalary
{

    internal class Salary
    {
        public int salarySocialFeeMin { get; set; } = 500000;
        public int salarySocialFeeMax { get; set; } = 1125000;

        public delegate decimal SalaryDelegate(decimal salary);

        public decimal IncomeTax(decimal salary) // Եկամտահարկ
        {
            decimal incomeTax = (salary * 20) / 100;
            Console.WriteLine($"Income tax is {incomeTax}");
            return incomeTax;
        }

        public decimal SocialFee(decimal salary) // Սոցիալական վճար
        {
            // 0 - 500000                          5%
            // 500001 - 1000000                    10% - 25000
            // 1000001 - ~~~                       87500

            decimal socialFee = 0;
            if (salary > 0 && salary <= salarySocialFeeMin)
            {
                socialFee = (salary * 5) / 100;    
            } else if(salary > (salarySocialFeeMin + 1) && salary < salarySocialFeeMax)
            {
                socialFee = (((salary * 10) / 100) - 25000);
            } else if(salary > (salarySocialFeeMax + 1))
            {
                socialFee = 87500;
            }

            Console.WriteLine($"Social Fee is {socialFee}");
            return socialFee;

        }

        public decimal StampDuty(decimal salary) // Դրոշմանիշային վճար
        {
            // Մինչև 100 000 դրամ հաշվարկման բազայի դեպքում՝ 1500 դրամ
            // 100 001 - ից մինչև 200 000 դրամ հաշվարկման բազայի դեպքում՝ 3000 դրամ
            // 200 001 - ից մինչև 500 000 դրամ հաշվարկման բազայի դեպքում՝ 5500 դրամ
            // 500 001 - ից մինչև 1 000 000 դրամ հաշվարկման բազայի դեպքում՝ 8500 դրամ
            // 1 000 001 դրամ և ավելի հաշվարկման բազայի դեպքում՝ 15 000 դրամ

            decimal stampDuty = 0;
            if (salary <= 100000)
            {
                stampDuty = 1500;
            } else if(salary > 100001 && salary <= 200000)
            {
                stampDuty = 3000;
            } else if(salary > 200001 && salary <= 500000)
            {
                stampDuty = 5500;
            } else if (salary > 500001 && salary <= 1000000)
            {
                stampDuty = 8500;
            } else if(salary > 1000001)
            {
                stampDuty = 15000;
            }

            Console.WriteLine($"Stamp Duty is {stampDuty}");
            return stampDuty;
        }


        public decimal CleanBalance(decimal salary) // Մաքուր Մնացորդ
        {
            decimal cleanBalance = salary - IncomeTax(salary) - SocialFee(salary) - StampDuty(salary);
            Console.WriteLine($"Your Clean Balance {cleanBalance}");
            return cleanBalance;
        }
    }
}
