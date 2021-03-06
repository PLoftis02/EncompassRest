using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    /// <summary>
    /// MIServiceArchLog
    /// </summary>
    public sealed partial class MIServiceArchLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        private DirtyList<LogComment> _commentList;
        private DirtyValue<string> _comments;
        private DirtyValue<DateTime?> _dateUtc;
        private DirtyValue<string> _details;
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        private DirtyValue<string> _guid;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        private DirtyValue<int?> _logRecordIndex;
        private DirtyValue<string> _name;
        private DirtyValue<string> _result;
        private DirtyValue<bool?> _showAlert;
        private DirtyValue<string> _systemId;
        private DirtyValue<DateTime?> _updatedDateUtc;

        /// <summary>
        /// MIServiceArchLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// MIServiceArchLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// MIServiceArchLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// MIServiceArchLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// MIServiceArchLog Details
        /// </summary>
        public string Details { get => _details; set => SetField(ref _details, value); }

        /// <summary>
        /// MIServiceArchLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// MIServiceArchLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// MIServiceArchLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// MIServiceArchLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// MIServiceArchLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// MIServiceArchLog Name
        /// </summary>
        public string Name { get => _name; set => SetField(ref _name, value); }

        /// <summary>
        /// MIServiceArchLog Result
        /// </summary>
        public string Result { get => _result; set => SetField(ref _result, value); }

        /// <summary>
        /// MIServiceArchLog ShowAlert
        /// </summary>
        public bool? ShowAlert { get => _showAlert; set => SetField(ref _showAlert, value); }

        /// <summary>
        /// MIServiceArchLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// MIServiceArchLog UpdatedDateUtc
        /// </summary>
        public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
    }
}