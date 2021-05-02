using System;
     class Student
    {
        //write your code here
        public int RegNo;
        public string Name;
        private int Topic1;
        private int Topic2;
        private int Topic3;
        private int Topic4;
        private int myVar = 6;
        public int Length{
            get{return myVar=6;}
        }
        public object this[int index]
        {
        //write your code here
            set{
                if(index==0){
                    int.TryParse(value.ToString(),out RegNo);
                }
                if(index==1){
                    Name = value.ToString();
                }
                if(index==2){
                    int.TryParse(value.ToString(),out Topic1);
                }
                if(index==3){
                    int.TryParse(value.ToString(),out Topic2);
                }
                if(index==4){
                    int.TryParse(value.ToString(),out Topic3);
                }
                if(index==5){
                    int.TryParse(value.ToString(),out Topic4);
                }
            }
            get{
                if(index==0){
                    return RegNo;
                }
                if(index==1){
                    return Name;
                }
                if(index==2){
                    return Topic1;
                }
                if(index==3){
                    return Topic2;
                }
                if(index==4){
                    return Topic3;
                }
                if(index==5){
                    return Topic4;
                }
                return "";
            }
        }
        
}
