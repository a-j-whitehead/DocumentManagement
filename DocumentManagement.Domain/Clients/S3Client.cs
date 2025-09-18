using DocumentManagement.Domain.Templates;

namespace DocumentManagement.Domain.Clients
{
    internal class S3Client : IS3Client
    {
        void IS3Client.UploadTemplate(Template template)
        {
            throw new NotImplementedException();
        }

        Stream IS3Client.DownloadTemplate(Template template)
        {
            throw new NotImplementedException();
        }
    }
}
