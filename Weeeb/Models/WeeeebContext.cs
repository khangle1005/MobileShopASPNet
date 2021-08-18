using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Weeeb.Models
{
    public class WeeeebContext
    {
        public WeeeebContext()
        {

        }
        public string ConnectionString { get; set; }
        public WeeeebContext (string connectionstring)
        {
            this.ConnectionString = connectionstring;
        }
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<Products> GetSanPham1()
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products WHERE product_id BETWEEN 70 AND 75", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Products> GetSanPham2()
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products WHERE product_id BETWEEN 59 AND 65", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public Products GetProByMa(int id)
        {
            Products s = new Products();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from products where product_id=@masach";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("masach", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        s.product_id = int.Parse(reader["product_id"].ToString());
                        s.product_cat = int.Parse(reader["product_cat"].ToString());
                        s.product_brand = int.Parse(reader["product_brand"].ToString());
                        s.product_title = reader["product_title"].ToString();
                        s.product_price = int.Parse(reader["product_price"].ToString());
                        s.product_desc = reader["product_desc"].ToString();
                        s.product_image = reader["product_image"].ToString();
                        s.product_keywords = reader["product_keywords"].ToString();
                    }

                }
            }
            return s;
        }
        public List<Products> GetSanPham3()
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products,categories WHERE product_cat=cat_id AND product_id BETWEEN $product_id AND $product_id+3", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Products> GetSanPhamCat(int cat)
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products WHERE product_cat =@cat", conn);
                cmd.Parameters.AddWithValue("cat", cat);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Products> GetSanPhamBrand(int cat)
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products WHERE product_brand =@cat", conn);
                cmd.Parameters.AddWithValue("cat", cat);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Products> GetSanPham()
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<User_Info> GetTaiKhoan()
        {
            List<User_Info> list = new List<User_Info>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM user_info", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User_Info()
                        {
                            user_id = int.Parse(reader["user_id"].ToString()),
                            first_name = reader["first_name"].ToString(),
                            last_name = reader["last_name"].ToString(),
                            email = reader["email"].ToString(),
                            password = reader["password"].ToString(),
                            mobile = reader["mobile"].ToString(),
                            address1 = reader["address1"].ToString(),
                            address2 = reader["address2"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Email_Info> GetEmail()
        {
            List<Email_Info> list = new List<Email_Info>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM email_info", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Email_Info()
                        {
                            email_id = int.Parse(reader["email_id"].ToString()),
                            email = reader["email"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Categories> GetCat()
        {
            List<Categories> list = new List<Categories>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM categories", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Categories()
                        {
                            cat_id = int.Parse(reader["cat_id"].ToString()),
                            cat_title = reader["cat_title"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Brands> GetBra()
        {
            List<Brands> list = new List<Brands>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM brands", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Brands()
                        {
                            brand_id = int.Parse(reader["brand_id"].ToString()),
                            brand_title = reader["brand_title"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public int AddUser(User_Info s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into user_info(first_name, last_name,email,password,mobile,address1,address2) values (@first_name,@last_name,@email,@password,@mobile,@address1,@address2)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("first_name", s.first_name);
                cmd.Parameters.AddWithValue("last_name", s.last_name);
                cmd.Parameters.AddWithValue("email", s.email);
                cmd.Parameters.AddWithValue("password", s.password);
                cmd.Parameters.AddWithValue("mobile", s.mobile);
                cmd.Parameters.AddWithValue("address1", s.address1);
                cmd.Parameters.AddWithValue("address2", s.address2);

                return (cmd.ExecuteNonQuery());

            }
        }
        public int AddPro(Products s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into products(product_cat, product_brand,product_title,product_price,product_desc,product_image,product_keywords) values (@a,@b,@c,@d,@e,@f,@g)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", s.product_cat);
                cmd.Parameters.AddWithValue("b", s.product_brand);
                cmd.Parameters.AddWithValue("c", s.product_title);
                cmd.Parameters.AddWithValue("d", s.product_price);
                cmd.Parameters.AddWithValue("e", s.product_desc);
                cmd.Parameters.AddWithValue("f", s.product_image);
                cmd.Parameters.AddWithValue("g", s.product_keywords);

                return (cmd.ExecuteNonQuery());

            }
        }
        public int UpdatePro(Products kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update products set product_cat = @a, product_brand = @b, product_title = @c, product_price = @d, product_desc = @e, product_image = @f, product_keywords = @g where product_id = @h";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", kh.product_cat);
                cmd.Parameters.AddWithValue("b", kh.product_brand);
                cmd.Parameters.AddWithValue("c", kh.product_title);
                cmd.Parameters.AddWithValue("d", kh.product_price);
                cmd.Parameters.AddWithValue("e", kh.product_desc);
                cmd.Parameters.AddWithValue("f", kh.product_image);
                cmd.Parameters.AddWithValue("g", kh.product_keywords);
                cmd.Parameters.AddWithValue("h", kh.product_id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int UpdateUser(User_Info kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update user_info set first_name = @first_name, last_name = @last_name, email = @email, password = @password, mobile = @mobile, address1 = @address1, address2 = @address2 where user_id = @idi";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("first_name", kh.first_name);
                cmd.Parameters.AddWithValue("last_name", kh.last_name);
                cmd.Parameters.AddWithValue("email", kh.email);
                cmd.Parameters.AddWithValue("password", kh.password);
                cmd.Parameters.AddWithValue("mobile", kh.mobile);
                cmd.Parameters.AddWithValue("address1", kh.address1);
                cmd.Parameters.AddWithValue("address2", kh.address2);
                cmd.Parameters.AddWithValue("idi", kh.user_id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public User_Info GetTaiKhoanByMa(int Id)
        {
            User_Info tk = new User_Info();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from user_info where user_id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tk.user_id = int.Parse(reader["user_id"].ToString());
                        tk.first_name = reader["first_name"].ToString();
                        tk.last_name = reader["last_name"].ToString();
                        tk.email = reader["email"].ToString();
                        tk.password = reader["password"].ToString();
                        tk.mobile = reader["mobile"].ToString();
                        tk.address1 = reader["address1"].ToString();
                        tk.address2 = reader["address2"].ToString();
                    }
                }
            }
            return tk;
        }
        public int XoaUser(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from user_info where user_id=@user_id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("user_id", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaPro(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from products where product_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public Categories GetCatByMa(int id)
        {
            Categories s = new Categories();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from categories where cat_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        s.cat_id = int.Parse(reader["cat_id"].ToString());
                        s.cat_title = reader["cat_title"].ToString();
                    }

                }
            }
            return s;
        }
        public int AddCat(Categories s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into categories(cat_id, cat_title) values (@a,@b)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", s.cat_id);
                cmd.Parameters.AddWithValue("b", s.cat_title);
                return (cmd.ExecuteNonQuery());

            }
        }
        public int UpdateCat(Categories kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update categories set cat_title = @a where cat_id = @b";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", kh.cat_title);
                cmd.Parameters.AddWithValue("b", kh.cat_id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int UpdateEmail(Email_Info kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update email_info set email = @a where email_id = @b";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", kh.email);
                cmd.Parameters.AddWithValue("b", kh.email_id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaCat(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from categories where cat_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int Login(string email, string password)
        {
            List<User_Info> list = new List<User_Info>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from user_info ", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User_Info()
                        {
                            user_id = int.Parse(reader["user_id"].ToString()),
                            first_name = reader["first_name"].ToString(),
                            last_name = reader["last_name"].ToString(),
                            email = reader["email"].ToString(),
                            password = reader["password"].ToString(),
                            mobile = reader["mobile"].ToString(),
                            address1 = reader["address1"].ToString(),
                            address2 = reader["address2"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            foreach (User_Info tk in list)
            {
                if (string.Compare(email, tk.email, false) == 0)
                {
                    if (string.Compare(password, tk.password, false) == 0)
                    {
                        if (tk.email == "admin")
                            return 1;
                        else return 0;
                    }
                }
            }
            return -1;
        }
        public string GetFname(string email, string password)
        {
            string a = "";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select first_name from user_info where email=@a and password=@b", conn);
                cmd.Parameters.AddWithValue("a", email);
                cmd.Parameters.AddWithValue("b", password);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        a = reader["first_name"].ToString();
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return a;
        }
        public string getUserId(string email, string password)
        {
            string a = "";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select user_id from user_info where email=@a and password=@b", conn);
                cmd.Parameters.AddWithValue("a", email);
                cmd.Parameters.AddWithValue("b", password);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        a = reader["user_id"].ToString();
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return a;
        }
        public List<Products> GetSanPhamSearch(string searchString)
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from products where product_title like @tensach ", conn);
                cmd.Parameters.AddWithValue("tensach", "%" + searchString + "%");
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from products where product_keywords like @tacgia ", conn);
                cmd.Parameters.AddWithValue("tacgia", "%" + searchString + "%");
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Products> PriceBetween(string min, string max)
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from products where product_price BETWEEN @min and @max ", conn);
                cmd.Parameters.AddWithValue("min", int.Parse(min));
                cmd.Parameters.AddWithValue("max", int.Parse(max));
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public Brands GetBraByMa(int id)
        {
            Brands s = new Brands();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from brands where brand_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        s.brand_id = int.Parse(reader["brand_id"].ToString());
                        s.brand_title = reader["brand_title"].ToString();
                    }

                }
            }
            return s;
        }
        public int AddBra(Brands s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into brands(brand_id, brand_title) values (@a,@b)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", s.brand_id);
                cmd.Parameters.AddWithValue("b", s.brand_title);
                return (cmd.ExecuteNonQuery());

            }
        }
        public int UpdateBra(Brands kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update brands set brand_title = @a where brand_id = @b";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", kh.brand_title);
                cmd.Parameters.AddWithValue("b", kh.brand_id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaBra(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from brands where brand_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public List<Orders> GetOrders()
        {
            List<Orders> list = new List<Orders>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM orders", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Orders()
                        {
                            order_id = int.Parse(reader["order_id"].ToString()),
                            user_id = int.Parse(reader["user_id"].ToString()),
                            order_date = reader["order_date"].ToString(),
                            quantity = int.Parse(reader["quantity"].ToString()),
                            total = int.Parse(reader["total"].ToString()),
                            paid_status = int.Parse(reader["paid_status"].ToString()),
                            status = int.Parse(reader["status"].ToString()),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public Orders getOrder(int id)
        {
            Orders o = new Orders();

            /*using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from orders where order_id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        *//*s.email_id = int.Parse(reader["email_id"].ToString());*/
                        /*s.email = reader["email"].ToString();*//*
                        o.order_id = int.Parse(reader["order_id"].ToString());
                        o.user_id = int.Parse(reader["user_id"].ToString());
                        o.order_date = reader["order_date"].ToString();
                        o.user_id = int.Parse(reader["user_id"].ToString());
                        o.user_id = int.Parse(reader["user_id"].ToString());
                        o.user_id = int.Parse(reader["user_id"].ToString());
                        o.user_id = int.Parse(reader["user_id"].ToString());

                    }

                }
            }*/

            return o;
        }
        public Email_Info GetEmailByMa(int id)
        {
            Email_Info s = new Email_Info();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from email_info where email_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        s.email_id = int.Parse(reader["email_id"].ToString());
                        s.email = reader["email"].ToString();
                    }

                }
            }
            return s;
        }
        public int XoaOrder(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from orders_info where order_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaEmail(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from email_info where email_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int AddEmail(Email_Info s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into email_info values (@a,@b)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", s.email_id);
                cmd.Parameters.AddWithValue("b", s.email);
                return (cmd.ExecuteNonQuery());

            }
        }
        public int AddOrd(Orders s)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into orders values (@order_id,@user_id,@order_date,@quantity,@total,@paid_stt,@stt)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("order_id", "null");
                cmd.Parameters.AddWithValue("user_id", s.user_id);
                cmd.Parameters.AddWithValue("order_date", "null");
                cmd.Parameters.AddWithValue("quantity", 0);
                cmd.Parameters.AddWithValue("total", 0);
                cmd.Parameters.AddWithValue("paid_stt", 0);
                cmd.Parameters.AddWithValue("stt", 0);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int getLastOrder(int user_id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT max(order_id) FROM orders WHERE user_id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", user_id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return int.Parse(reader["max(order_id)"].ToString());
                    }
                }
            }
            return 0;
        }
        public int AddOrdInfo(Order_info s)
        {
            int oid = getLastOrder(s.user_id);

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into order_info values (@order_info_id,@order_id,@user_id,@name,@phone,@email,@address,@note)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("order_info_id", "null");
                cmd.Parameters.AddWithValue("order_id", oid);
                cmd.Parameters.AddWithValue("user_id", s.user_id);
                cmd.Parameters.AddWithValue("name", s.name);
                cmd.Parameters.AddWithValue("phone", s.phone);
                cmd.Parameters.AddWithValue("email", s.email);
                cmd.Parameters.AddWithValue("address", s.address);
                cmd.Parameters.AddWithValue("note", s.note);

                return (cmd.ExecuteNonQuery());
            }
        }
        public long CountC(long s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); 
                var str ="select COUNT(product_id) from products where product_cat = @a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", s);
                System.Int64 count = (System.Int64)cmd.ExecuteScalar();
                return count;

            }
        }
        public long CountB(long s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select COUNT(product_id) from products where product_brand = @a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", s);
                System.Int64 count = (System.Int64)cmd.ExecuteScalar();
                return count;

            }
        }
        /*
        public int AddOrd(Orders_Info s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into orders_info values (@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m,@n)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", s.order_id);
                cmd.Parameters.AddWithValue("b", s.user_id);
                cmd.Parameters.AddWithValue("c", s.f_name);
                cmd.Parameters.AddWithValue("d", s.email);
                cmd.Parameters.AddWithValue("e", s.address);
                cmd.Parameters.AddWithValue("f", s.city);
                cmd.Parameters.AddWithValue("g", s.state);
                cmd.Parameters.AddWithValue("h", s.zip);
                cmd.Parameters.AddWithValue("i", s.cardname);
                cmd.Parameters.AddWithValue("j", s.cardnumber);
                cmd.Parameters.AddWithValue("k", s.expdate);
                cmd.Parameters.AddWithValue("l", s.prod_count);
                cmd.Parameters.AddWithValue("m", s.total_amt);
                cmd.Parameters.AddWithValue("n", s.cvv);
                return (cmd.ExecuteNonQuery());

            }
        }
        public int UpdateOrd(Orders_Info kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update orders_info set brand_title = @a where brand_id = @b";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", kh.brand_title);
                cmd.Parameters.AddWithValue("b", kh.brand_id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaBra(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from brands where brand_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        */
    }
}
   
