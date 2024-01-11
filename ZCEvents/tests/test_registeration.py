import pytest
from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait

@pytest.fixture
def browser():
    driver = webdriver.Chrome()
    yield driver
    driver.quit()

def test_register_form(browser):
    # In port assumptions we trust.
    browser.get("http://localhost:5093")
    browser.find_element(By.ID, "inputName").send_keys("Omar")
    browser.find_element(By.ID, "inputEmail").send_keys("omar@zc.com")
    browser.find_element(By.ID, "inputphone").send_keys("+201234567890")
    browser.find_element(By.ID, "inputPassword").send_keys("verystrongpassword123")
    browser.find_element(By.ID, "confirmPassword").send_keys("verystrongpassword123")

    browser.find_element(By.ID, "sellerRadio").click()

    browser.find_element(By.ID, "registerSubmit").click()

    assert "ZCEvents" in browser.title
