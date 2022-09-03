use std::fmt::{Display, Formatter, Result};

#[derive(Debug, PartialEq)]
pub struct Clock {
    hours: i32,
    minutes: i32,
}

impl Clock {
    pub fn new(hours: i32, minutes: i32) -> Self {
        let mut hours = hours;
        let mut minutes = minutes;
        while minutes < 0 {
            minutes += 60;
            hours -= 1;
        }
        while hours < 0 {
            hours += 24;
        }
        Self {
            hours: (hours + minutes / 60) % 24,
            minutes: minutes % 60,
        }
    }
    pub fn add_minutes(&self, minutes: i32) -> Self {
        Clock::new(self.hours, self.minutes + minutes)
    }
}

impl Display for Clock {
    fn fmt(&self, f: &mut Formatter<'_>) -> Result {
        write!(f, "{:02}:{:02}", self.hours, self.minutes)
    }
}
