public class Shared
{
    public static string ConnectionString = string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MYSQLCONNSTR_MealSharingDb")) ?
   "" :
   Environment.GetEnvironmentVariable("MYSQLCONNSTR_MealSharingDb");
}