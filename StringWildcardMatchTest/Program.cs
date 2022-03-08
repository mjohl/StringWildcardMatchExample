using Console = System.Console;
using Microsoft.VisualBasic.CompilerServices;

var ignoredDataDogErrors = new List<String>();

ignoredDataDogErrors.Add("*No * files found*"); 
ignoredDataDogErrors.Add("*No matching file found on SFTP server*");
ignoredDataDogErrors.Add("*Unable to acquire access token for client id*");
ignoredDataDogErrors.Add("*No such host is known*");
ignoredDataDogErrors.Add("*Delta token not retrieved. A full sync will need to be performed*");

if (ignoredDataDogErrors.Any(ignoredDataDogError =>
        LikeOperator.LikeString("Error message was: 'No matching files found", ignoredDataDogError, Microsoft.VisualBasic.CompareMethod.Binary)))
{
        Console.WriteLine("Match Found!");
}
