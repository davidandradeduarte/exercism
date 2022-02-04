#[derive(Debug, PartialEq)]
pub enum Comparison {
    Equal,
    Sublist,
    Superlist,
    Unequal,
}

pub fn sublist<T: PartialEq>(_first_list: &[T], _second_list: &[T]) -> Comparison {
    fn find_window<T: PartialEq>(a : &[T], b : &[T]) -> bool {
        a.is_empty() || b.windows(a.len()).any(|v| a == v)
    }

    if _first_list.eq(_second_list) {
        return Comparison::Equal;
    }

    if _first_list.len() < _second_list.len() && find_window(_first_list, _second_list){
        return Comparison::Sublist;
    } else if find_window(_second_list, _first_list) {
        return Comparison::Superlist;
    }

    Comparison::Unequal
}
