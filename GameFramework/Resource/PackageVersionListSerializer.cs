﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

namespace GameFramework.Resource
{
    /// <summary>
    /// 单机模式版本资源列表序列化器。
    /// </summary>
    public sealed class PackageVersionListSerializer : VersionListSerializer<PackageVersionList>
    {
        private static readonly byte[] VersionListHeader = new byte[] { (byte)'E', (byte)'L', (byte)'P' };

        /// <summary>
        /// 初始化单机模式版本资源列表序列化器的新实例。
        /// </summary>
        public PackageVersionListSerializer()
        {
        }

        /// <summary>
        /// 获取单机模式版本资源列表头标识。
        /// </summary>
        /// <returns>单机模式版本资源列表头标识。</returns>
        protected override byte[] GetHeader()
        {
            return VersionListHeader;
        }
    }
}