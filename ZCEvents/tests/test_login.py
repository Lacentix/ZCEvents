import pytest
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC

@pytest.fixture
def browser():
    driver = webdriver.Chrome(executable_path='/opt/homebrew/bin/chromedriver')
    yield driver
    driver.quit()

def test_login_form(browser):
    # In port assumptions we trust.
    browser.get("http://localhost:5093")

    browser.find_element(By.ID, "inputEmail").send_keys("omar@zc.com")
    browser.find_element(By.ID, "inputPassword").send_keys("verystrongpassword123")

    browser.find_element(By.ID, "customerRadio").click()

    browser.find_element(By.NAME, "submitType").click()

    assert "ZCEvents" in browser.title
