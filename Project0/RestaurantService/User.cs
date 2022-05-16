namespace RestaurantService
{


    public class User
    {

        private string _userName { get; set; }

        private string _userPass {get; set; }
        public string _realName {get; set;}
       // private const MIN_PW_SIZE = 8;
        // constructor
        public User()
        {
            //get => userName;
            _userName = "admin";
            _userPass = "fiopwk";
            _realName = "Juan Mcdonald";
            //could use _LEN but _SIZE includes space to terminating null


        }
            // properties
            public string realName {get; set;}
            private string RealName {
                get => _realName;
                set => realName = value;
            }
            
            private string UserName { 
                get => _userName;
                set 
                { 
                    if (!string.IsNullOrEmpty(value))
                     _userName = value;
                    else
                    throw new ArgumentNullException("exception thrown when null reference is passed");
                }
            }

          //  private string userPass;
            public string UserPass
            {
                get => _userPass;
                set
                {
                    if(!(value.Length < 8))
                     _userPass = value;
                    else
                        throw new Exception("password length restriction min length 8");
                    

                }
            }
    
    }
}
