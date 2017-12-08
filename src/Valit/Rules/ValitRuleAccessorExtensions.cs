using Valit.Exceptions;

namespace Valit.Rules
{
    internal static class ValitRuleAccessorExtensions
    {
        internal static IValitRuleAccessor<TObject, TProperty> GetAccessor<TObject, TProperty>(this IValitRule<TObject, TProperty> rule) where TObject : class
        {
            var accessor = rule as IValitRuleAccessor<TObject, TProperty>;
            accessor.ThrowIfNull("Rule doesn't have an accessor");

            return accessor;
        }

        internal static IValitRuleAccessor<TObject> GetAccessor<TObject>(this IValitRule<TObject> rule) where TObject : class
        {
            var accessor = rule as IValitRuleAccessor<TObject>;
            accessor.ThrowIfNull("Rule doesn't have an accessor");

            return accessor;
        }
    }
}
