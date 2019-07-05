namespace Static
{
    class Person
    {
        /// <summary>
        /// 记录所有存活着的人的数量。
        /// </summary>
        public static int TotalPopulation { get; private set; }

        /// <summary>
        /// 获取一个值，指示该人是否为男性。
        /// </summary>
        public bool IsMale { get; }
        private Person(bool isMale)
        {
            IsMale = isMale;
            TotalPopulation++;
        }

        /// <summary>
        /// 获取一个值，指示该人是否已死亡。
        /// </summary>
        public bool IsDead { get; private set; }

        /// <summary>
        /// 死亡。
        /// </summary>
        public void Die()
        {
            IsDead = true;
            TotalPopulation--;
        }
        ~Person()
        {
            // 如果不曾调用过Die()，就在被销毁时减少总人口。
            if(!IsDead)
            {
                TotalPopulation--;
            }
        }


        /// <summary>
        /// 一个伪随机数生成器，用于随机确定小孩的性别。
        /// </summary>
        private System.Random random = new System.Random();

        /// <summary>
        /// 生孩子。
        /// </summary>
        /// <param name="anotherPerson"></param>
        /// <returns></returns>
        public Person MakeABabyWith(Person anotherPerson)
        {
            if(IsMale != anotherPerson.IsMale)
            {
                int randomInt = random.Next(1);
                bool randomBool = System.Convert.ToBoolean(randomInt);
                return new Person(randomBool);
            }
            else
            {
                // 同性生不出孩子。
                return null;
            }
        }


        /// <summary>
        /// 亚当。
        /// </summary>
        public static Person Eve { get; } = new Person(false);

        /// <summary>
        /// 夏娃。
        /// </summary>
        public static Person Adam { get; } = new Person(true);
    }
}
