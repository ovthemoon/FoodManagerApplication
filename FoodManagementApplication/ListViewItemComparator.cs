using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementApplication
{
    using System.Collections;
    using System.Windows.Forms;

    public class ListViewItemComparator : IComparer
    {
        private int col;
        private SortOrder order;

        public ListViewItemComparator(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        /// <summary>
        /// 비교 인터페이스 구현. 두 개의 ListViewItem 객체를 비교합니다.(GPT 생성)
        /// </summary>
        /// <param name="x">비교할 첫 번째 객체</param>
        /// <param name="y">비교할 두 번째 객체</param>
        /// <returns>
        /// 비교 결과를 나타내는 정수:
        /// -1: 첫 번째 객체가 두 번째 객체보다 작음.
        /// 0: 두 객체가 동일함.
        /// 1: 첫 번째 객체가 두 번째 객체보다 큼.
        /// </returns>
        public int Compare(object x, object y)
        {
            // 비교 결과를 저장할 변수 초기화
            int returnVal = -1;

            // col 변수는 비교할 열(서브아이템)의 인덱스를 나타냅니다.
            // 두 ListViewItem 객체의 특정 서브아이템 텍스트를 비교
            returnVal = string.Compare(((ListViewItem)x).SubItems[col].Text,
                                       ((ListViewItem)y).SubItems[col].Text);

            // order 변수는 정렬 순서를 나타냅니다.
            // 정렬 순서가 내림차순이면 비교 결과에 -1을 곱하여 반전시킵니다.
            if (order == SortOrder.Descending)
                returnVal *= -1;

            // 비교 결과 반환
            return returnVal;
        }

    }

}
