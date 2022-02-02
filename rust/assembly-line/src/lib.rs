// This stub file contains items which aren't used yet; feel free to remove this module attribute
// to enable stricter warnings.
// #![allow(unused)]

const CARS_AT_LOWEST_SPEED: i32 = 221;

pub fn production_rate_per_hour(speed: u8) -> f64 {
    match speed {
        0..=4 => speed as f64 * CARS_AT_LOWEST_SPEED as f64,
        5..=8 => speed as f64 * CARS_AT_LOWEST_SPEED as f64 * 0.9,
        9..=10 => speed as f64 * CARS_AT_LOWEST_SPEED as f64 * 0.77,
        _ => panic!("Invalid speed: {}", speed),
    }
}

pub fn working_items_per_minute(speed: u8) -> u32 {
    (production_rate_per_hour(speed) / 60.0) as u32
}
