namespace MVVMTest.ViewModel
{
    public class CheckBoxViewModelCase
    {
        /// <summary>
        ///     创建CheckBoxViewModel实例
        /// </summary>
        private readonly CheckBoxViewModel checkBoxViewModel = new CheckBoxViewModel
        {
            firstCheckBox = false,
            secondCheckBox = false,
            thirdCheckBox = false
        };

        /// <summary>
        ///     创建获取实例方法
        /// </summary>
        /// <returns></returns>
        public CheckBoxViewModel GetCheckBoxViewModel() => checkBoxViewModel;
    }
}