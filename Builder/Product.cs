
namespace DesignPatterns.Builder
{
    public class Product
    {
        private string productName;
        private string companyName;
        private string part1;
        private string part2;
        private string part3;
        private string part4;

        public Product(string productName, string companyName, string part1, string part2, string part3, string part4)
        {
            this.productName = productName;
            this.companyName = companyName;
            this.part1 = part1;
            this.part2 = part2;
            this.part3 = part3;
            this.part4 = part4;
        }

        public override string ToString()
        {
            return "productName:" + productName + "\n" +
                "companyName:" + companyName + "\n" +
                "part1:" + part1 + "\n" +
                "part2:" + part2 + "\n" +
                "part3:" + part3 + "\n" +
                "part4:" + part4 + "\n";
        }

        public class Builder
        {
            private string productName;
            private string companyName;
            private string part1;
            private string part2;
            private string part3;
            private string part4;

            public Product Build()
            {
                return new Product(this.productName, this.companyName, this.part1, this.part2, this.part3, this.part4);
            }

            public Builder ProductName(string productName)
            {
                this.productName = productName;
                return this;
            }

            public Builder CompanyName(string companyName)
            {
                this.companyName = companyName;
                return this;
            }

            public Builder Part1(string part1)
            {
                this.part1 = part1;
                return this;
            }

            public Builder Part2(string part2)
            {
                this.part2 = part2;
                return this;
            }

            public Builder Part3(string part3)
            {
                this.part3 = part3;
                return this;
            }

            public Builder Part4(string part4)
            {
                this.part4 = part4;
                return this;
            }
        }
    }
}
