

namespace com.hzins.channel.api.model.req
{
    /// <summary>
    /// <p>
    /// �������
    /// </p>
    /// </summary>
    /// <author>hz15031081</author>
    /// <date>2015-4-2 5:10:35</date>
    /// <version></version>
    public abstract class BaseReq
    {

        /// <summary>
        /// ������ˮ�ţ�ÿ�����󶼲�һ������������������
        /// </summary>
        public string transNo;

        /// <summary>
        /// ������
        /// </summary>
        public int partnerId;

        /// <summary>
        /// ǩ������֤��ݣ���ֹ��������۸�
        /// </summary>
        public string sign;

        /// <summary>
        /// ������Ա
        /// </summary>
        public string userId;

    }
}
