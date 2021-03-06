using System.ComponentModel.DataAnnotations;
using autodoc.tasks.domain.Common;

namespace autodoc.tasks.domain.Entities;

public class TaskFileEntity : BaseEntity
{
	[MaxLength(255), MinLength(2)]
	public string FileName { get; set; }

	[MaxLength(255)]
	public string? FileExtension { get; set; }

	public long Size { get; set; } = 0;

	public Guid LocalStorageFileId { get; set; }

	public bool IsStoredCompressed { get; set; } = false;

	public int TaskId { get; set; }

	public virtual TaskEntity Task { get; set; }
}