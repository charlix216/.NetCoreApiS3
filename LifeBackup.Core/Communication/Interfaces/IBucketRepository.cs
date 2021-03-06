﻿using System;
using System.Threading.Tasks;
using LifeBackup.Core.Communication.Bucket;

namespace LifeBackup.Core.Communication.Interfaces
{
    public interface IBucketRepository
    {

        Task<bool> DoesS3BucketExist(string bucketName);

        Task<CreateBucketResponse> CreateBucket(string bucketName);

    }
}
