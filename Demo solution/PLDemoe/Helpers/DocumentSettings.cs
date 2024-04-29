using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PLDemoe.Helpers
{
	public class DocumentSettings
	{
		public async static Task<string> UploadFileAsync(IFormFile formFile, string FolderName)
		{

			// 1. Get Located Folder Path

			//string FolderPath = "E:\\Route\\Back-end\\7 ASP.NET MVC\\Demoes\\Session 3&4\\Demoe solution\\PLDemoe\\wwwroot\\Files\\" + FolderName;
			//string FolderPath = Directory.GetCurrentDirectory() + @"\wwwroot\Files\" + FolderName;
			string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files", FolderName);

			// 2. Get File Name and Make it Unique
			string FileName = $"{Guid.NewGuid()}{formFile.FileName}";

			// 3. Get File Path
			string FilePath = Path.Combine(FolderPath, FileName);

			// 4. Save File at Streams : [Data Per Time]
			using var FileStream = new FileStream(FilePath, FileMode.Create);
			await formFile.CopyToAsync(FileStream);

			// 5. Return File Name
			return FileName;
		}
		public static void DeleteFile(string FileName, string FolderName)
		{
			if (FileName is not null && FolderName is not null)
			{
				string FilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files", FolderName, FileName);
				if (File.Exists(FilePath))
					File.Delete(FilePath);
			}
		}
	}
}
