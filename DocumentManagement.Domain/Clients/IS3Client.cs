using DocumentManagement.Domain.Templates;

namespace DocumentManagement.Domain.Clients
{
    internal interface IS3Client // TODO - rename this to IS3Acl?
    {
        internal void UploadTemplate(Template template);
        internal Stream DownloadTemplate(Template template);
    }
}