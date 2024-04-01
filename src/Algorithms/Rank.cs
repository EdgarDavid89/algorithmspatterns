namespace Algorthims 
{

    public static class Rank
    {

        public static int MaximunRest(this List<int> lisInt)
        {
            int maximunRest = -1;
            int minimunRest =  lisInt[0];

            for (int i = 1; i < lisInt.Count; i++)
            {
                if(minimunRest < lisInt[i])
                {
                    int rest =  lisInt[i] - minimunRest;

                    maximunRest = maximunRest > rest ?  maximunRest : minimunRest;
                }
                else
                minimunRest =  lisInt[i];
            }
            return maximunRest;
        }




    }

}